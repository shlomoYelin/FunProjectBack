using FunProject.Application.HubModule;
using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.Services.Interfaces;
using FunProject.Application.OrdersModule.Validators.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Enums;
using FunProject.Domain.Models;
using System.Linq;

namespace FunProject.Application.OrdersModule.WorkFlows
{
    public class UpdateOrderWorkFlow : IUpdateOrderWorkFlow
    {
        private readonly IUpdateOrderTask _updateOrderTask;
        private readonly IUpdateOrderValidator _updateOrderValidator;
        private readonly IOrderPaymentCalculationService _orderPaymentCalculationService;
        private readonly IGetProductOrdersByOrderIdTask _getProductOrdersByOrderIdTask;
        private readonly IProductOrderGetActionTypeTask _productOrderGetActionTypeTask;
        private readonly IGetProductOrdersToDeleteTask _getProductOrdersToDeleteTask;
        private readonly IDeleteProductOrdersTask _deleteProductOrdersTask;
        private readonly ICreateProductOrderTask _createProductOrderTask;
        private readonly IUpdateProductOrderTask _updateProductOrderTask;
        private readonly IProductStockUpdateTask _productStockUpdateTask;
        private readonly IAddProductsToStockTask _addProductsToStockTask;
        private readonly IGetProductsByIdsTask _getProductsByIdsTask;
        private readonly IProductsStockHub _productsStockHub;
        private readonly IMergeProductsOrdersIdsTask _mergeProductsOrdersIdsTask;

        public UpdateOrderWorkFlow(IUpdateOrderTask updateOrderTask,
            IUpdateOrderValidator updateOrderValidator,
            IOrderPaymentCalculationService orderPaymentCalculationService,
            IGetProductOrdersByOrderIdTask getProductOrdersByOrderIdTask,
            IProductOrderGetActionTypeTask productOrderGetActionTypeTask,
            IGetProductOrdersToDeleteTask getProductOrdersToDeleteTask,
            IDeleteProductOrdersTask deleteProductOrdersTask,
            ICreateProductOrderTask createProductOrderTask,
            IUpdateProductOrderTask updateProductOrderTask,
            IProductStockUpdateTask productStockUpdateTask,
            IAddProductsToStockTask addProductsToStockTask,
            IGetProductsByIdsTask getProductsByIdsTask,
            IProductsStockHub productsStockHub,
            IMergeProductsOrdersIdsTask mergeProductsOrdersIdsTask)
        {
            _updateOrderTask = updateOrderTask;
            _updateOrderValidator = updateOrderValidator;
            _orderPaymentCalculationService = orderPaymentCalculationService;
            _getProductOrdersByOrderIdTask = getProductOrdersByOrderIdTask;
            _productOrderGetActionTypeTask = productOrderGetActionTypeTask;
            _getProductOrdersToDeleteTask = getProductOrdersToDeleteTask;
            _deleteProductOrdersTask = deleteProductOrdersTask;
            _createProductOrderTask = createProductOrderTask;
            _updateProductOrderTask = updateProductOrderTask;
            _productStockUpdateTask = productStockUpdateTask;
            _addProductsToStockTask = addProductsToStockTask;
            _getProductsByIdsTask = getProductsByIdsTask;
            _productsStockHub = productsStockHub;
            _mergeProductsOrdersIdsTask = mergeProductsOrdersIdsTask;
        }
        public ActionStatusModel Update(OrderDto order)
        {
            try
            {
                _updateOrderValidator.Validation(order);

                order.Payment = _orderPaymentCalculationService.Calculate(order);

                var prevProductOrders = _getProductOrdersByOrderIdTask.Get(order.Id);
                var newProductOrders = order.ProductOrders;

                newProductOrders.ToList().ForEach(newProductOrder =>
                {
                    var prevProductOrder = prevProductOrders.FirstOrDefault(productOrder => productOrder.ProductId == newProductOrder.ProductId);

                    var actionType =
                        _productOrderGetActionTypeTask.Get(prevProductOrder, newProductOrder);

                    if (actionType == ActionType.Create)
                    {
                        _productStockUpdateTask.Update(newProductOrder.ProductId, -newProductOrder.Quantity, newProductOrder.ProductDescription);

                        _createProductOrderTask.Create(newProductOrder);
                    }
                    else if (actionType == ActionType.Update)
                    {
                        _productStockUpdateTask.Update(newProductOrder.ProductId, -(newProductOrder.Quantity - prevProductOrder.Quantity), newProductOrder.ProductDescription);

                        _updateProductOrderTask.Update(newProductOrder);
                    }
                });

                var toDelete = _getProductOrdersToDeleteTask.Get(prevProductOrders, newProductOrders);

                if (toDelete.Count != 0)
                {
                    _addProductsToStockTask.Add(toDelete);

                    _deleteProductOrdersTask.Delete(toDelete);
                }

                order.ProductOrders = null;
                _updateOrderTask.Update(order);

                var allProductOrdersIds = _mergeProductsOrdersIdsTask.Merge(prevProductOrders,newProductOrders);

                _productsStockHub.SendUpdate(_getProductsByIdsTask.Get(allProductOrdersIds));
            }
            catch (System.Exception ex)
            {
                return new() { Success = false, Message = ex.Message };
            }

            return new() { Success = true };
        }
    }
}
