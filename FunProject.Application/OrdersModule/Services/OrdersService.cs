using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.Models;
using FunProject.Application.OrdersModule.Services.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Interfaces;
using FunProject.Domain.Models;
using System.Collections.Generic;
using System.IO;

namespace FunProject.Application.OrdersModule.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IGetOrdersByFiltersWorkFlow _getOrdersByFiltersWorkFlow;
        private readonly ICreateOrderWorkFlow _createOrderWorkFlow;
        private readonly IDeleteOrderWorkFlow _deleteOrderWorkFlow;
        private readonly IGetOrderByIdWorkFlow _getOrderByIdWorkFlow;
        private readonly IUpdateOrderWorkFlow _updateOrderWorkFlow;
        private readonly IGetOrdersByFiltersAsExcelWorkFlow _getOrdersByFiltersAsExcelWorkFlow;
        private readonly IGetTotalMonthlyOrdersByYearWorkFlow _getTotalMonthlyOrdersByYearWorkFlow;

        public OrdersService(IGetOrdersByFiltersWorkFlow getOrdersByFiltersWorkFlow, ICreateOrderWorkFlow createOrderWorkFlow, IDeleteOrderWorkFlow deleteOrderWorkFlow, IGetOrderByIdWorkFlow getOrderByIdWorkFlow, IUpdateOrderWorkFlow updateOrderWorkFlow, IGetOrdersByFiltersAsExcelWorkFlow getOrdersByFiltersAsExcelWorkFlow, IGetTotalMonthlyOrdersByYearWorkFlow getTotalMonthlyOrdersByYearWorkFlow)
        {
            _getOrdersByFiltersWorkFlow = getOrdersByFiltersWorkFlow;
            _createOrderWorkFlow = createOrderWorkFlow;
            _deleteOrderWorkFlow = deleteOrderWorkFlow;
            _getOrderByIdWorkFlow = getOrderByIdWorkFlow;
            _updateOrderWorkFlow = updateOrderWorkFlow;
            _getOrdersByFiltersAsExcelWorkFlow = getOrdersByFiltersAsExcelWorkFlow;
            _getTotalMonthlyOrdersByYearWorkFlow = getTotalMonthlyOrdersByYearWorkFlow;
        }

        public IList<OrderDto> GetOrdersByFilters(OrderFiltersValuesModel filtersValues)
        {
            return _getOrdersByFiltersWorkFlow.Get(filtersValues);
        }

        public ActionStatusModel CreateOrder(OrderDto order)
        {
            return _createOrderWorkFlow.Create(order);
        }

        public ActionStatusModel DeleteOrder(int id)
        {
            return _deleteOrderWorkFlow.Delete(id);
        }

        public OrderDto GetOrder(int id)
        {
            return _getOrderByIdWorkFlow.Get(id);
        }

        public ActionStatusModel UpdateOrder(OrderDto order)
        {
            return _updateOrderWorkFlow.Update(order);
        }

        public MemoryStream GetOrdersByFiltersAsExcel(OrderFiltersValuesModel filtersValues)
        {
            return _getOrdersByFiltersAsExcelWorkFlow.Get(filtersValues);
        }

        public List<TotalMonthlyOrdersModel> GetTotalMonthlyOrdersByYear(int year)
        {
            return _getTotalMonthlyOrdersByYearWorkFlow.Get(year);
        }
    }
}
