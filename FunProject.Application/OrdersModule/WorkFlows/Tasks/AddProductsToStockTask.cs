using FunProject.Application.Data.Products.Command;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class AddProductsToStockTask : IAddProductsToStockTask
    {
        private readonly IProductStockUpdateCommand _productStockUpdateCommand;

        public AddProductsToStockTask(IProductStockUpdateCommand productStockUpdateCommand)
        {
            _productStockUpdateCommand = productStockUpdateCommand;
        }

        public void Add(IList<ProductOrder> productOrders)
        {
            productOrders.ToList().ForEach(productOrder =>
            {
                try
                {
                    _productStockUpdateCommand.Update(productOrder.ProductId, productOrder.Quantity);
                }
                catch (Exception)
                {
                    throw new Exception("Failed to update Stock");
                }
            });
        }
    }
}
