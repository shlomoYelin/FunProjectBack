using FunProject.Application.ProductsModule.Dtos;
using FunProject.Application.ProductsModule.Validators.Interfaces;
using FunProject.Application.ProductsModule.Validators.Validations.Interfaces;

namespace FunProject.Application.ProductsModule.Validators
{
    public class UpdateProductValidator : IUpdateProductValidator
    {
        private readonly IProductIsExistsValidation _productIsExistsValidation;
        private readonly IProductRequierdValidation _productRequierdValidation;

        public UpdateProductValidator(IProductIsExistsValidation productIsExistsValidation, IProductRequierdValidation productRequierdValidation)
        {
            _productIsExistsValidation = productIsExistsValidation;
            _productRequierdValidation = productRequierdValidation;
        }
        public void Validate(ProductDto product)
        {
            _productIsExistsValidation.Validate(product.Id);
            _productRequierdValidation.Validate(product);
        }
    }
}
