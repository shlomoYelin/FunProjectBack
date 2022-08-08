using FunProject.Application.Data.Orders.Query.QueriesPlugins;
using FunProject.Application.OrdersModule.Models;
using FunProject.Domain.Entities;
using System.Linq;

namespace FunProject.Persistence.Orders.Query.QueriesPlugins
{
    public class FilterOrdersByDateRange : IFilterOrdersByDateRange
    {
        public IQueryable<Order> Execute(IQueryable<Order> query, OrderFiltersValuesModel filtersValues)
        {
            return filtersValues.DateRange == null ? query : query
                .Where(o => (filtersValues.DateRange.Start == null || o.Date >= filtersValues.DateRange.Start)
                && (filtersValues.DateRange.End == null || o.Date <= filtersValues.DateRange.End));
        }
    }
}
