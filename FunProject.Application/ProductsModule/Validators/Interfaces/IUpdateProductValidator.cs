using FunProject.Application.ProductsModule.Dtos;

namespace FunProject.Application.ProductsModule.Validators.Interfaces
{
    public interface IUpdateProductValidator
    {
        void Validate(ProductDto product);
    }
}
