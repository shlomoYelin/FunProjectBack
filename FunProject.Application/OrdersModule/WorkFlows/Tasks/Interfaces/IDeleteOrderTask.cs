using FunProject.Domain.Entities;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IDeleteOrderTask
    {
        void Delete(Order order);
    }

}
