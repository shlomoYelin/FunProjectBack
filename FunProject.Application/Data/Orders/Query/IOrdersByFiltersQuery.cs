using FunProject.Application.Data.Orders.Query.QueriesPlugins;
using FunProject.Application.OrdersModule.Models;
using FunProject.Domain.Entities;
using System.Collections.Generic;

namespace FunProject.Application.Data.Orders.Query
{
    public interface IOrdersByFiltersQuery
    {
        IList<Order> Get(IList<IBaseOrderQueryPlugin> queryPlugins, OrderFiltersValuesModel filtersValues);
    }
}
