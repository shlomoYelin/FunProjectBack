using FunProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace FunProject.Persistence.Orders.ExtensionsMetods
{
    public static class OrderIncludeIfExtensions
    {
        public static IQueryable<Order> IncludeIf(this IQueryable<Order> orders, bool condition, Expression<Func<Order, Customer>> predicate)
        {
            if (condition)
            {
                orders = orders.Include(predicate);
            }
            return orders;
        }
    }
}
