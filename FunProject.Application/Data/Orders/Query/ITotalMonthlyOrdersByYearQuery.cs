using FunProject.Application.OrdersModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Application.Data.Orders.Query
{
    public interface ITotalMonthlyOrdersByYearQuery
    {
        List<TotalMonthlyOrdersModel> Get(int year);
    }
}
