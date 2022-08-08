namespace FunProject.Application.Data.Products.Command
{
    public interface IAddProductsToStockByOrderIdCommand
    {
        void Add(int orderId);
    }
}
