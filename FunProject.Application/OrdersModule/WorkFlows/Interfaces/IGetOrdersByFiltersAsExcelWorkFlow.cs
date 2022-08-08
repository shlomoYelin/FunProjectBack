using FunProject.Application.OrdersModule.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Application.OrdersModule.WorkFlows.Interfaces
{
    public interface IGetOrdersByFiltersAsExcelWorkFlow
    {
        MemoryStream Get(OrderFiltersValuesModel filtersValues);
    }
}
