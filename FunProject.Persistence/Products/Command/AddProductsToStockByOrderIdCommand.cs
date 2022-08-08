using FunProject.Application.Data.Products.Command;
using FunProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FunProject.Persistence.Products.Command
{
    public class AddProductsToStockByOrderIdCommand : IAddProductsToStockByOrderIdCommand
    {
        private readonly AppDbContext _appDbContext;

        public AddProductsToStockByOrderIdCommand(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(int orderId)
        {
            _appDbContext.ProductOrders
                .Where(p => p.OrderId == orderId)
                .Include(po => po.Product)
                .Select(productOrder => new ProductOrder
                {
                    Quantity = productOrder.Quantity,
                    Product = productOrder.Product
                })
                .ToList()
                .ForEach(productOrder => productOrder.Product.Quantity += productOrder.Quantity);

            _ = _appDbContext.SaveChanges();
        }
    }
}
