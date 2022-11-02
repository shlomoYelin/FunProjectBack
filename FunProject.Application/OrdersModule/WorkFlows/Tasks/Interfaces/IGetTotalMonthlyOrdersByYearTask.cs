using FunProject.Application.OrdersModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IGetTotalMonthlyOrdersByYearTask
    {
        List<TotalMonthlyOrdersModel> Get(int year);
    }
}
