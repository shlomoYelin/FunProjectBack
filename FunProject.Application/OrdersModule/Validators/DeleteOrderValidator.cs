using FunProject.Application.OrdersModule.Validators.Interfaces;
using FunProject.Application.OrdersModule.Validators.Validations.Interfaces;
using System;

namespace FunProject.Application.OrdersModule.Validators
{
    public class DeleteOrderValidator : IDeleteOrderValidator
    {
        private readonly IOrderIsExistsValidation _orderIsExistsValidation;

        public DeleteOrderValidator(IOrderIsExistsValidation orderIsExistsValidation)
        {
            _orderIsExistsValidation = orderIsExistsValidation;
        }
        public void Validate(int orderId)
        {
            try
            {
                _orderIsExistsValidation.Validate(orderId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
