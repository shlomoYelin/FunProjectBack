using FunProject.Application.Data.Products.Command;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using System;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class ProductStockUpdateTask : IProductStockUpdateTask
    {
        private readonly IProductStockUpdateCommand _productStockUpdateCommand;

        public ProductStockUpdateTask(IProductStockUpdateCommand productStockUpdateCommand)
        {
            _productStockUpdateCommand = productStockUpdateCommand;
        }
        public void Update(int productId, int quantity, string productName)
        {
            try
            {
                _productStockUpdateCommand.Update(productId, quantity);
            }
            catch (Exception)
            {
                throw new Exception($"Failed to update {productName} Stock");
            }
        }
    }
}
