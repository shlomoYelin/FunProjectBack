using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.ProductOrderModule.Dtos;
using FunProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
