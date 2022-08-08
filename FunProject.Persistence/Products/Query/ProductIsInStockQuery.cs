using FunProject.Application.Data.Products.Query;
using System.Linq;

namespace FunProject.Persistence.Products.Query
{
    public class ProductIsInStockQuery : IProductIsInStockQuery
    {
        private readonly AppDbContext _appDbContext;

        public ProductIsInStockQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public int IsInStock(int productId, int quantity)
        {
            return _appDbContext.Products
                .Where(p => p.Id == productId)
                .Select(p => p.Quantity)
                .FirstOrDefault();
            //return _appDbContext.Products.Any(p => p.Id == productId && p.Quantity >= quantity);
        }
    }
}
