using FunProject.Application.Data.Orders.Query.QueriesPlugins;
using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.Models;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IOrdersByFiltersTask
    {
        IList<OrderDto> Get(OrderFiltersValuesModel filtersValues, IList<IBaseOrderQueryPlugin> plugins);
    }
}
