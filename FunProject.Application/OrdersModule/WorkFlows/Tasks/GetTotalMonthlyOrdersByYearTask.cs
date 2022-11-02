using FunProject.Application.Data.Orders.Query;
using FunProject.Application.OrdersModule.Models;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class GetTotalMonthlyOrdersByYearTask : IGetTotalMonthlyOrdersByYearTask
    {
        private readonly ITotalMonthlyOrdersByYearQuery _totalMonthlyOrdersByYearQuery;

        public GetTotalMonthlyOrdersByYearTask(ITotalMonthlyOrdersByYearQuery totalMonthlyOrdersByYearQuery)
        {
            _totalMonthlyOrdersByYearQuery = totalMonthlyOrdersByYearQuery;
        }

        public List<TotalMonthlyOrdersModel> Get(int year)
        {
            return _totalMonthlyOrdersByYearQuery.Get(year);
        }
    }
}
