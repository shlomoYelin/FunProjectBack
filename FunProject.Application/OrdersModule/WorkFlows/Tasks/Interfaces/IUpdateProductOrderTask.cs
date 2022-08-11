using FunProject.Application.OrdersModule.Dtos;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IUpdateProductOrderTask
    {
        void Update(ProductOrderDto productOrder);
    }
}
