using FunProject.Application.Data.ProductOrders.Command;
using FunProject.Domain.Entities;

namespace FunProject.Persistence.ProducOrders.Command
{
    public class CreateProductOrderCommand : ICreateProductOrderCommand
    {
        private readonly AppDbContext _appDbContext;

        public CreateProductOrderCommand(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Create(ProductOrder productOrder)
        {
            _ = _appDbContext.ProductOrders.Add(productOrder);
            _ = _appDbContext.SaveChanges();
        }
    }
}
