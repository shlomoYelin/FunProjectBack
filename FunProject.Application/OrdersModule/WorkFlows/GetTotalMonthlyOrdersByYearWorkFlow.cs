using FunProject.Application.OrdersModule.Models;
using FunProject.Application.OrdersModule.WorkFlows.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Application.OrdersModule.WorkFlows
{
    public class GetTotalMonthlyOrdersByYearWorkFlow : IGetTotalMonthlyOrdersByYearWorkFlow
    {
        private readonly IGetTotalMonthlyOrdersByYearTask _getTotalMonthlyOrdersByYearTask;

        public GetTotalMonthlyOrdersByYearWorkFlow(IGetTotalMonthlyOrdersByYearTask getTotalMonthlyOrdersByYearTask)
        {
            _getTotalMonthlyOrdersByYearTask = getTotalMonthlyOrdersByYearTask;
        }

        public List<TotalMonthlyOrdersModel> Get(int year)
        {
            return _getTotalMonthlyOrdersByYearTask.Get(year);
        }
    }
}
