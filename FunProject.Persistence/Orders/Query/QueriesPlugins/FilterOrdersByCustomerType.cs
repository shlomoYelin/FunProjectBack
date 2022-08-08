using FunProject.Application.Data.Orders.Query.QueriesPlugins;
using FunProject.Application.OrdersModule.Models;
using FunProject.Domain.Entities;
using System.Linq;

namespace FunProject.Persistence.Orders.Query.QueriesPlugins
{
    public class FilterOrdersByCustomerType : IFilterOrdersByCustomerType
    {
        public IQueryable<Order> Execute(IQueryable<Order> query, OrderFiltersValuesModel filtersValues)
        {
            return filtersValues.CustomerType == null ? query : query
                .Where(o => o.Customer.Type == (int)filtersValues.CustomerType);
        }
    }
}
