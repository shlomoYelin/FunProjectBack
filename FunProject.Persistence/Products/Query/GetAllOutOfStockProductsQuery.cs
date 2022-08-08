using FunProject.Application.Data.Products.Query;
using FunProject.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Persistence.Products.Query
{
    public class GetAllOutOfStockProductsQuery : IGetAllOutOfStockProductsQuery
    {
        private readonly AppDbContext _appDbContext;

        public GetAllOutOfStockProductsQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IList<Product> Get()
        {
            return _appDbContext
                .Products
                .Where(p => p.Quantity < 1)
                .ToList();
        }
    }
}
