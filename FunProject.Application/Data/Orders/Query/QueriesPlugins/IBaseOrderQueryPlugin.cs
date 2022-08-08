using FunProject.Application.OrdersModule.Models;
using FunProject.Domain.Entities;
using System.Linq;

namespace FunProject.Application.Data.Orders.Query.QueriesPlugins
{
    public interface IBaseOrderQueryPlugin
    {
        IQueryable<Order> Execute(IQueryable<Order> query, OrderFiltersValuesModel filtersValues);
    }
}
