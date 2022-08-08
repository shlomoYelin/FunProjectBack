using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.Models;
using FunProject.Application.OrdersModule.WorkFlows.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows
{
    public class GetOrdersByFiltersWorkFlow : IGetOrdersByFiltersWorkFlow
    {
        private readonly IGetAllOrderQueryPlginsTask _getAllOrderQueryPlginsTask;
        private readonly IOrdersByFiltersTask _ordersByFiltersTask;

        public GetOrdersByFiltersWorkFlow(
            IGetAllOrderQueryPlginsTask getAllOrderQueryPlginsTask,
            IOrdersByFiltersTask ordersByFiltersTask
            )
        {
            _getAllOrderQueryPlginsTask = getAllOrderQueryPlginsTask;
            _ordersByFiltersTask = ordersByFiltersTask;
        }
        public IList<OrderDto> Get(OrderFiltersValuesModel filtersValues)
        {
            var plagins = _getAllOrderQueryPlginsTask.Get();

            var orders = _ordersByFiltersTask.Get(filtersValues, plagins);

            return orders;
        }
    }
}
