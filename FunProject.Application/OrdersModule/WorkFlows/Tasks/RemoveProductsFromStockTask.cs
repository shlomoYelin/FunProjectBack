using FunProject.Application.Data.Products.Command;
using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class RemoveProductsFromStockTask : IRemoveProductsFromStockTask
    {
        private readonly IProductStockUpdateCommand _productStockUpdateCommand;

        public RemoveProductsFromStockTask(IProductStockUpdateCommand productStockUpdateCommand)
        {
            _productStockUpdateCommand = productStockUpdateCommand;
        }

        public void Remove(IList<ProductOrderDto> productOrders)
        {
            productOrders.ToList().ForEach(productOrder =>
            {
                try
                {
                    _productStockUpdateCommand.Update(productOrder.ProductId, -productOrder.Quantity);
                }
                catch (Exception)
                {
                    throw new Exception($"Failed to update {productOrder.ProductDescription} Stock");
                }
            });
        }
    }
}
