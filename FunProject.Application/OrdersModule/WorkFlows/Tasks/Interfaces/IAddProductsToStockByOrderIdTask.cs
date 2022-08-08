namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IAddProductsToStockByOrderIdTask
    {
        void Add(int orderId);
    }
}
