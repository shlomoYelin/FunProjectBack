using FunProject.Application.Data.Orders.Command;
using FunProject.Domain.Entities;

namespace FunProject.Persistence.Orders.Command
{
    public class DeleteOrderCommand : IDeleteOrderCommand
    {
        private readonly AppDbContext _appDbContext;

        public DeleteOrderCommand(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Delete(Order order)
        {
            _ = _appDbContext.Orders.Remove(order);
            _ = _appDbContext.SaveChanges();
        }
    }
}
