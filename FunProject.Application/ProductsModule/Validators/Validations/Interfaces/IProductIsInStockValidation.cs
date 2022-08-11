using FunProject.Application.OrdersModule.Dtos;
using System.Collections.Generic;

namespace FunProject.Application.ProductsModule.Validators.Validations.Interfaces
{
    public interface IProductIsInStockValidation
    {
        void Validate(IList<ProductOrderDto> productOrders);
    }
}
