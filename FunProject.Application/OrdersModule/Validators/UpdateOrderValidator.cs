using FunProject.Application.CustomersModule.Validators.Validations.Interfaces;
using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.Validators.Interfaces;
using FunProject.Application.OrdersModule.Validators.Validations.Interfaces;
using FunProject.Application.ProductsModule.Validators.Validations.Interfaces;

namespace FunProject.Application.OrdersModule.Validators
{
    public class UpdateOrderValidator : IUpdateOrderValidator
    {
        private readonly ICustomerIsExistsValidation _customerIsExistsValidation;
        private readonly IProductsIsExistsValidation _productsIsExistsValidation;
        private readonly IOrderIsExistsValidation _orderIsExistsValidation;


        public UpdateOrderValidator(
            IProductsIsExistsValidation productsIsExistsValidation, 
            ICustomerIsExistsValidation customerIsExistsValidation,
            IOrderIsExistsValidation orderIsExistsValidation)
        {
            _customerIsExistsValidation = customerIsExistsValidation;
            _productsIsExistsValidation = productsIsExistsValidation;
            _orderIsExistsValidation = orderIsExistsValidation;
        }

        public void Validation(OrderDto order)
        {
                _customerIsExistsValidation.Validate(order.CustomerId);

                _productsIsExistsValidation.Validate(order.ProductOrders);

                _orderIsExistsValidation.Validate(order.Id);
        }
    }
}
