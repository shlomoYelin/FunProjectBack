namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IProductStockUpdateTask
    {
        void Update(int productId, int quantity, string productName);
    }
}
