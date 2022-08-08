using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.Models;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows.Interfaces
{
    public interface IGetOrdersByFiltersWorkFlow
    {
        IList<OrderDto> Get(OrderFiltersValuesModel filtersValues);
    }
}
