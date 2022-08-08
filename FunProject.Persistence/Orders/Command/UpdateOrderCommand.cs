using FunProject.Application.Data.Orders.Command;
using FunProject.Domain.Entities;

namespace FunProject.Persistence.Orders.Command
{
    public class UpdateOrderCommand : IUpdateOrderCommand
    {
        private readonly AppDbContext _appDbContext;

        public UpdateOrderCommand(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Update(Order order)
        {
            _ = _appDbContext.Orders.Update(order);
            _ = _appDbContext.SaveChanges();
        }
    }
}
