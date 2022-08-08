using FunProject.Application.Data.Products.Query;
using FunProject.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Persistence.Products.Query
{
    public class ProductsByIdsQuery : IProductsByIdsQuery
    {
        private readonly AppDbContext _appDbContext;

        public ProductsByIdsQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IList<Product> Get(IList<int> productsIds)
        {
            return _appDbContext.Products
                .Where(p => productsIds.Contains(p.Id))
                .ToList();  
        }
    }
}
