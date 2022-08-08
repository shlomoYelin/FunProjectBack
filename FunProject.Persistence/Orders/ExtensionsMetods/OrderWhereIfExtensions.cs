using FunProject.Domain.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace FunProject.Persistence.Orders.ExtensionsMetods
{
    public static class OrderWhereIfExtensions
    {
        public static IQueryable<Order> WhereIf(this IQueryable<Order> orders, bool condition, Expression<Func<Order, bool>> predicate)
        {
            if (condition)
            {
                orders = orders.Where(predicate);
            }
            return orders;
        }
    }
}
