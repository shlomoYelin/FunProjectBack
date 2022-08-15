using FunProject.Application.Data.Orders.Query.QueriesPlugins;
using FunProject.Application.OrdersModule.Models;
using FunProject.Domain.Entities;
using System.Linq;

namespace FunProject.Persistence.Orders.Query.QueriesPlugins
{
    public class FilterOrdersByCustomerNameSearchValue : IFilterOrdersByCustomerNameSearchValue
    {//todo: move to application
        public IQueryable<Order> Execute(IQueryable<Order> query, OrderFiltersValuesModel filtersValues)
        {
            return string.IsNullOrEmpty(filtersValues.CustomerNameSearchValue) ? query : query
                .Where(o => o.Customer.FirstName.Contains(filtersValues.CustomerNameSearchValue) 
                || o.Customer.LastName.Contains(filtersValues.CustomerNameSearchValue));
        }
    }
}   
