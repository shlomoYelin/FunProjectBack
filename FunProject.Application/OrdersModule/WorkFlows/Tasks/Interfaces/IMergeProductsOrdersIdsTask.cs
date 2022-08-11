using FunProject.Application.OrdersModule.Dtos;
using FunProject.Domain.Entities;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IMergeProductsOrdersIdsTask
    {
        IList<int> Merge(IList<ProductOrder> prevProductOrders, IList<ProductOrderDto> newProductOrders);
    }
}
