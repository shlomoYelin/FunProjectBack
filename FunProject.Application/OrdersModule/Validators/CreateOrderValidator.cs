using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.Validators.Interfaces;
using FunProject.Application.CustomersModule.Validators.Validations.Interfaces;
using FunProject.Application.ProductsModule.Validators.Validations.Interfaces;

namespace FunProject.Application.OrdersModule.Validators
{
    public class CreateOrderValidator : ICreateOrderValidator
    {
        private readonly ICustomerIsExistsValidation _customerIsExistsValidation;
        private readonly IProductsIsExistsValidation _productsIsExistsValidation;
        private readonly IProductIsInStockValidation _productIsInStockValidation;

        public CreateOrderValidator(
            ICustomerIsExistsValidation customerIsExistsValidation,
            IProductsIsExistsValidation productsIsExistsValidation,
            IProductIsInStockValidation productIsInStockValidation)
        {
            _customerIsExistsValidation = customerIsExistsValidation;
            _productsIsExistsValidation = productsIsExistsValidation;
            _productIsInStockValidation = productIsInStockValidation;
        }
        public void Validation(OrderDto order)
        {
            _customerIsExistsValidation.Validate(order.CustomerId);

            _productsIsExistsValidation.Validate(order.ProductOrders);

            _productIsInStockValidation.Validate(order.ProductOrders);
        }
    }
}
