using FunProject.Application.ProductsModule.WorkFlows.Interfaces;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;

namespace FunProject.Application.ProductsModule.WorkFlows
{
    public class ProductIsInStockWprkFlow : IProductIsInStockWprkFlow
    {
        private readonly IProductIsInStockTask _productIsInStockTask;

        public ProductIsInStockWprkFlow(IProductIsInStockTask  productIsInStockTask)
        {
            _productIsInStockTask = productIsInStockTask;
        }
        public int IsInStock(int productId, int quantity)
        {
            return _productIsInStockTask.IsInStock(productId, quantity);
        }
    }
}
