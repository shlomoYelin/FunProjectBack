using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.Models;
using FunProject.Domain.Models;
using System.Collections.Generic;
using System.IO;

namespace FunProject.Application.OrdersModule.Services.Interfaces
{
    public interface IOrdersService
    {
        IList<OrderDto> GetOrdersByFilters(OrderFiltersValuesModel filtersValues);
        MemoryStream GetOrdersByFiltersAsExcel(OrderFiltersValuesModel filtersValues);
        OrderDto GetOrder(int id);  
        ActionStatusModel CreateOrder(OrderDto order);
        ActionStatusModel UpdateOrder(OrderDto order);
        ActionStatusModel DeleteOrder(int id);
        List<TotalMonthlyOrdersModel> GetTotalMonthlyOrdersByYear(int year);
    }
}