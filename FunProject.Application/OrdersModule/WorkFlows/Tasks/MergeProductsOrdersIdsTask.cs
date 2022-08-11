using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class MergeProductsOrdersIdsTask : IMergeProductsOrdersIdsTask
    {
        public IList<int> Merge(IList<ProductOrder> prevProductOrders, IList<ProductOrderDto> newProductOrders)
        {
            var allIds = prevProductOrders.Select(x => x.ProductId).ToHashSet();

            allIds
                .UnionWith(newProductOrders.Select(x => x.ProductId)
                .ToList());

            return allIds.ToList();
        }
    }
}
