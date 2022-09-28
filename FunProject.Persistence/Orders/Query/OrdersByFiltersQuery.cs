using FunProject.Application.Data.Orders.Query;
using FunProject.Application.Data.Orders.Query.QueriesPlugins;
using FunProject.Application.OrdersModule.Models;
using FunProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Persistence.Orders.Query
{
    public class OrdersByFiltersQuery : IOrdersByFiltersQuery
    {
        private readonly AppDbContext _appDbContext;

        public OrdersByFiltersQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IList<Order> Get(IList<IBaseOrderQueryPlugin> queryPlugins, OrderFiltersValuesModel filtersValues)
        {
            var query = _appDbContext.Orders
                .Include(o => o.Customer)
                .Include(o => o.ProductOrders)
                .ThenInclude(productOrder => productOrder.Product)
                .AsQueryable();


            return queryPlugins
               .Aggregate(query, (prevQueryable, queryPlugin) =>
               queryPlugin.Execute(prevQueryable, filtersValues))
               .ToList();
        }
    }
}
