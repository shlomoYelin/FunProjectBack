using FunProject.Application.ProductOrderModule.Dtos;
using FunProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IMergeProductsOrdersIdsTask
    {
        IList<int> Merge(IList<ProductOrder> prevProductOrders, IList<ProductOrderDto> newProductOrders);
    }
}
