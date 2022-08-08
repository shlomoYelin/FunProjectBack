namespace FunProject.Application.Data.Products.Command
{
    public interface IProductStockUpdateCommand
    {
        void Update(int productId, int quantity);
    }
}
