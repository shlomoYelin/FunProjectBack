namespace FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces
{
    public interface IProductIsInStockTask
    {
        int IsInStock(int productId, int quantity);
    }
}
