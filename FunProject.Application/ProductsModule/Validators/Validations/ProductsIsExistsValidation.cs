using FunProject.Application.Data.Products.Query;
using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.ProductsModule.Validators.Validations.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Application.ProductsModule.Validators.Validations
{
    public class ProductsIsExistsValidation : IProductsIsExistsValidation
    {
        private readonly IProductIsExistsQuery _productIsExistsQuery;
        public ProductsIsExistsValidation(IProductIsExistsQuery productIsExistsQuery)
        {
            _productIsExistsQuery = productIsExistsQuery;
        }

        public void Validate(IList<ProductOrderDto> productOrders)
        {
            productOrders.ToList().ForEach(productOrder =>
            {
                if (!_productIsExistsQuery.IsExists(productOrder.ProductId))
                {
                    throw new System.Exception($"{productOrder.ProductDescription} not found");
                }
            });
        }
    }
}



