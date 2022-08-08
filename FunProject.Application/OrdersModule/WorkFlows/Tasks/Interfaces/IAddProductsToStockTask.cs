using FunProject.Domain.Entities;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IAddProductsToStockTask
    {
        void Add(IList<ProductOrder> productOrders);
    }
}
