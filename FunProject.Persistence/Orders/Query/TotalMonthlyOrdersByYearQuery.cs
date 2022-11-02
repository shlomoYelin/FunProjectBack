using FunProject.Application.Data.Orders.Query;
using FunProject.Application.OrdersModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Persistence.Orders.Query
{
    public class TotalMonthlyOrdersByYearQuery : ITotalMonthlyOrdersByYearQuery
    {
        private readonly AppDbContext _appDbContext;
        public TotalMonthlyOrdersByYearQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<TotalMonthlyOrdersModel> Get(int year)
        {
            return _appDbContext.Orders.Where(o => o.Date.Year == year)
                .OrderBy(o => o.Date.Month)
                .GroupBy(o => o.Date.Month)
                .Select(group => new TotalMonthlyOrdersModel { Date = group.First().Date, Sum = group.Count() })
                .ToList();
        }
    }
}
