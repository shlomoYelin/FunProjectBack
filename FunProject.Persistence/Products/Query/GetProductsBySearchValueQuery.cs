using FunProject.Application.Data.Products.Query;
using FunProject.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Persistence.Products.Query
{
    public class GetProductsBySearchValueQuery : IGetProductsBySearchValueQuery
    {
        private readonly AppDbContext _appDbContext;

        public GetProductsBySearchValueQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IList<Product> Get(string searchValue)
        {
            return _appDbContext.Products
                .Where(p => p.Description.ToLower()
                .Contains(searchValue.ToLower()))
                .ToList();
        }
    }
}
