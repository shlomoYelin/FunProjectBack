using FunProject.Application.OrdersModule.Dtos;

namespace FunProject.Application.OrdersModule.Validators.Interfaces
{
    public interface IUpdateOrderValidator
    {
        void Validation(OrderDto order);
    }
}
