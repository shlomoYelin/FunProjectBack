using FunProject.Application.OrdersModule.Dtos;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface ICreateOrderTask
    {
        void Create(OrderDto order);
    }
}
