using FunProject.Application.OrdersModule.Dtos;

namespace FunProject.Application.OrdersModule.Validators.Interfaces
{
    public interface ICreateOrderValidator
    {
        void Validation(OrderDto order);
    }
}
