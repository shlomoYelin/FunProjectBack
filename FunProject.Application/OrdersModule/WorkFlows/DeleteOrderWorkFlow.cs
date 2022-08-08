using FunProject.Application.HubModule;
using FunProject.Application.OrdersModule.Validators.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Models;

namespace FunProject.Application.OrdersModule.WorkFlows
{
    public class DeleteOrderWorkFlow : IDeleteOrderWorkFlow
    {
        private readonly IDeleteOrderTask _deleteOrderTask;
        private readonly IDeleteOrderValidator _deleteOrderValidator;
        private readonly IAddProductsToStockByOrderIdTask _addProductsToStockByOrderIdTask;
        private readonly IGetProductsByOrderIdTask _getProductsByOrderIdTask;
        private readonly IProductsStockHub _productsStockHub;

        public DeleteOrderWorkFlow(IDeleteOrderTask deleteOrderTask,
            IDeleteOrderValidator deleteOrderValidator,
            IAddProductsToStockByOrderIdTask addProductsToStockByOrderIdTask,
            IGetProductsByOrderIdTask getProductsByOrderIdTask,
            IProductsStockHub productsStockHub)
        {
            _deleteOrderTask = deleteOrderTask;
            _deleteOrderValidator = deleteOrderValidator;
            _addProductsToStockByOrderIdTask = addProductsToStockByOrderIdTask;
            _getProductsByOrderIdTask = getProductsByOrderIdTask;
            _productsStockHub = productsStockHub;
        }

        public ActionStatusModel Delete(int id)
        {
            try
            {
                _deleteOrderValidator.Validate(id);

                _addProductsToStockByOrderIdTask.Add(id);

                var products = _getProductsByOrderIdTask.Get(id);

                _deleteOrderTask.Delete(new Domain.Entities.Order { Id = id });

                if(products.Count > 0)
                {
                    _productsStockHub.SendUpdate(products);
                }
            }
            catch (System.Exception ex)
            {
                return new() { Success = false, Message = ex.Message };
            }

            return new() { Success = true };

        }
    }
}
