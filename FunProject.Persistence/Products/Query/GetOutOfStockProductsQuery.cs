using FunProject.Application.Data.Products.Query;
using FunProject.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Persistence.Products.Query
{
    public class GetOutOfStockProductsQuery : IGetOutOfStockProductsQuery
    {
        private readonly AppDbContext _appDbContext;

        public GetOutOfStockProductsQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IList<ProductMinimalDetailsModel> Get(IList<int> productsIds)
        {
            return _appDbContext.Products
                .Where(p => productsIds.Contains(p.Id))
                .Select(p => new ProductMinimalDetailsModel { Id = p.Id, ProductName = p.Description, IsInStock = p.Quantity > 0 })
                .ToList();
        }
    }
}
