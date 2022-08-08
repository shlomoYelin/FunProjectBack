namespace FunProject.Application.ProductsModule.WorkFlows.Interfaces
{
    public interface IProductIsInStockWprkFlow
    {
        int IsInStock(int productId, int quantity);
    }
}
