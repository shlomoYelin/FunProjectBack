using FunProject.Application.ProductOrderModule.Dtos;
using System.Collections.Generic;

namespace FunProject.Application.ProductsModule.Validators.Validations.Interfaces
{
    public interface IProductIsInStockValidation
    {
        void Validate(IList<ProductOrderDto> productOrders);
    }
}
