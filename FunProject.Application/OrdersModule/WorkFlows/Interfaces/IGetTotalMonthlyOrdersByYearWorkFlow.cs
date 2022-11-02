using FunProject.Application.OrdersModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Application.OrdersModule.WorkFlows.Interfaces
{
    public interface IGetTotalMonthlyOrdersByYearWorkFlow
    {
        List<TotalMonthlyOrdersModel> Get(int year);
    }
}
