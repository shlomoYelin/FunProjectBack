using FunProject.Application.Data.Products.Query;
using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.ProductsModule.Validators.Validations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Application.ProductsModule.Validators.Validations
{
    public class ProductIsInStockValidation : IProductIsInStockValidation
    {
        private readonly IProductIsInStockQuery _productIsInStockQuery;

        public ProductIsInStockValidation(IProductIsInStockQuery productIsInStockQuery)
        {
            _productIsInStockQuery = productIsInStockQuery;
        }

        public void Validate(IList<ProductOrderDto> productOrders)
        {
            productOrders.ToList().ForEach(productOrder =>
            {
                if (_productIsInStockQuery.IsInStock(productOrder.ProductId, productOrder.Quantity) <= 0)
                {
                    throw new Exception($"{productOrder.ProductDescription} doesn't exist in the quantity you selected");
                }
            });
        }
    }
}
