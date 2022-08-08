using FunProject.Application.Data.Products.Query;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;

namespace FunProject.Application.ProductsModule.WorkFlows.Tasks
{
    public class ProductIsInStockTask : IProductIsInStockTask
    {
        private readonly IProductIsInStockQuery _productIsInStockQuery;

        public ProductIsInStockTask(IProductIsInStockQuery productIsInStockQuery)
        {
            _productIsInStockQuery = productIsInStockQuery;
        }

        public int IsInStock(int productId, int quantity)
        {
            return _productIsInStockQuery.IsInStock(productId, quantity);
        }
    }
}
