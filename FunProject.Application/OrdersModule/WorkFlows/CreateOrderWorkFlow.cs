using FunProject.Application.HubModule;
using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.Services.Interfaces;
using FunProject.Application.OrdersModule.Validators.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Models;
using System.Linq;

namespace FunProject.Application.OrdersModule.WorkFlows
{
    public class CreateOrderWorkFlow : ICreateOrderWorkFlow
    {
        private readonly ICreateOrderTask _createOrderTask;
        private readonly ICreateOrderValidator _createOrderValidator;
        private readonly IOrderPaymentCalculationService _orderPaymentCalculationService;
        private readonly IRemoveProductsFromStockTask _removeProductsFromStockTask;
        private readonly IGetProductsByIdsTask _getProductsByIdsTask;
        private readonly IProductsStockHub _productsStockHub;

        public CreateOrderWorkFlow(
            ICreateOrderTask createOrderTask,
            ICreateOrderValidator createOrderValidator,
            IOrderPaymentCalculationService orderPaymentCalculationService,
            IRemoveProductsFromStockTask removeProductsFromStockTask,
            IGetProductsByIdsTask getProductsByIdsTask,
            IProductsStockHub productsStockHub
            )
        {
            _createOrderTask = createOrderTask;
            _createOrderValidator = createOrderValidator;
            _orderPaymentCalculationService = orderPaymentCalculationService;
            _removeProductsFromStockTask = removeProductsFromStockTask;
            _getProductsByIdsTask = getProductsByIdsTask;
            _productsStockHub = productsStockHub;
        }

        public ActionStatusModel Create(OrderDto order)
        {
            try
            {
                _createOrderValidator.Validation(order);

                order.Payment = _orderPaymentCalculationService.Calculate(order);

                _removeProductsFromStockTask.Remove(order.ProductOrders);

                _createOrderTask.Create(order);

                var productsIds = order.ProductOrders
                    .Select(productOrder => productOrder.ProductId)
                    .ToList();

                var products = _getProductsByIdsTask.Get(productsIds);
                if (products.Count > 0)
                {
                    _productsStockHub.SendUpdate(products);
                }

                return new() { Success = true };
            }
            catch (System.Exception ex)
            {
                return new() { Success = false, Message = ex.Message };
            }
        }
    }
}
