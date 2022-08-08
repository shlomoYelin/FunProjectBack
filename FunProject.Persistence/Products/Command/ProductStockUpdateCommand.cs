using FunProject.Application.Data.Products.Command;
using System.Linq;

namespace FunProject.Persistence.Products.Command
{
    public class ProductStockUpdateCommand : IProductStockUpdateCommand
    {
        private readonly AppDbContext _appDbContext;

        public ProductStockUpdateCommand(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Update(int productId, int quantity)
        {
            _appDbContext.Products
                .FirstOrDefault(p => p.Id == productId)
                .Quantity += quantity;

            _ = _appDbContext.SaveChanges();
        }
    }
}
