using FunProject.Application.Data.ProductOrders.Command;
using FunProject.Domain.Entities;

namespace FunProject.Persistence.ProducOrders.Command
{
    public class UpdateProductOrderCommand : IUpdateProductOrderCommand
    {
        private readonly AppDbContext _appDbContext;

        public UpdateProductOrderCommand(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Update(ProductOrder productOrder)
        {
            _ = _appDbContext.ProductOrders.Update(productOrder);
            _ = _appDbContext.SaveChanges();
        }
    }
}
