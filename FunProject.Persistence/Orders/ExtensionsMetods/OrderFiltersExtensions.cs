using FunProject.Application.OrdersModule.Models;
using FunProject.Domain.Entities;
using System.Linq;

namespace FunProject.Persistence.Orders.ExtensionsMetods
{
    public static class OrderFiltersExtensions
    {
        public static IQueryable<Order> FilterExtensions(this IQueryable<Order> source, OrderFiltersValuesModel filtersValues)
        {
            return source
                .IncludeIf(!string.IsNullOrEmpty(filtersValues.CustomerNameSearchValue)
                || filtersValues.CustomerType > 0, o => o.Customer)

                .WhereIf(!string.IsNullOrEmpty(filtersValues.CustomerNameSearchValue),
                o => o.Customer.FirstName
                .Contains(filtersValues.CustomerNameSearchValue) || o.Customer.LastName
                .Contains(filtersValues.CustomerNameSearchValue))

                .WhereIf(filtersValues.CustomerType > 0, o => o.Customer.Type == (int)filtersValues.CustomerType)

                .WhereIf(filtersValues.DateRange != null,
                o => o.Date >= filtersValues.DateRange.Start && o.Date <= filtersValues.DateRange.End);
        }
    }
}
