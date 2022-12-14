using FunProject.Application.ProductsModule.Dtos;
using FunProject.Application.ProductsModule.Validators.Validations.Interfaces;

namespace FunProject.Application.ProductsModule.Validators.Validations
{
    public class ProductRequierdValidation : IProductRequierdValidation
    {
        public void Validate(ProductDto product)
        {
            string ErrorMessage = "";

            if (product.Description is null or "")
            {
                ErrorMessage = "Product name is required.";
            }

            if (product.Price <= 0)
            {
                ErrorMessage += " Product price is required.";
            }

            if (ErrorMessage.Length > 0)
            {
                throw new System.Exception(ErrorMessage);
            }
        }
    }
}
