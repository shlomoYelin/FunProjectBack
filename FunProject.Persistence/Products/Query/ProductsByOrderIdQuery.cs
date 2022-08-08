using FunProject.Application.Data.Products.Query;
using FunProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Persistence.Products.Query
{
    public class ProductsByOrderIdQuery : IProductsByOrderIdQuery
    {
        private readonly AppDbContext _appDbContext;

        public ProductsByOrderIdQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IList<Product> Get(int orderId)
        {
            return _appDbContext.ProductOrders
                .Where(productOrder => productOrder.OrderId == orderId)
                .Include(productOrder => productOrder.Product)
                .Select(productOrder => productOrder.Product)
                .ToList();
        }
    }
}
