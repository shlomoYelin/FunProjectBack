using FunProject.Application.Data.Products.Command;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using System;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class AddProductsToStockByOrderIdTask : IAddProductsToStockByOrderIdTask
    {
        private readonly IAddProductsToStockByOrderIdCommand _addProductsToStockByOrderIdCommand;

        public AddProductsToStockByOrderIdTask(IAddProductsToStockByOrderIdCommand addProductsToStockByOrderIdCommand)
        {
            _addProductsToStockByOrderIdCommand = addProductsToStockByOrderIdCommand;
        }
        public void Add(int orderId)
        {
            try
            {
                _addProductsToStockByOrderIdCommand.Add(orderId);
            }
            catch (Exception)
            {
                throw new Exception("Stock update faild");
            }
        }
    }
}
