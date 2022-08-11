using FunProject.Application.OrdersModule.Models;
using System.IO;

namespace FunProject.Application.OrdersModule.WorkFlows.Interfaces
{
    public interface IGetOrdersByFiltersAsExcelWorkFlow
    {
        MemoryStream Get(OrderFiltersValuesModel filtersValues);
    }
}
