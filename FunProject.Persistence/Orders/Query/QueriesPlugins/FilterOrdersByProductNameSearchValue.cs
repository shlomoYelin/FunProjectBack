using FunProject.Application.Data.Orders.Query.QueriesPlugins;
using FunProject.Application.OrdersModule.Models;
using FunProject.Domain.Entities;
using System.Linq;

namespace FunProject.Persistence.Orders.Query.QueriesPlugins
{
    public class FilterOrdersByProductNameSearchValue : IFilterOrdersByProductNameSearchValue
    {
        public IQueryable<Order> Execute(IQueryable<Order> query, OrderFiltersValuesModel filtersValues)
        {
            return string.IsNullOrEmpty(filtersValues.ProductNameSearchValue) ? query : query
                .Where(o => o.ProductOrders
                .Any(productOrder => 
                productOrder.Product.Description.Contains(filtersValues.ProductNameSearchValue)));
        }
    }
}
