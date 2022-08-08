using FunProject.Application.Data.Orders.Query;
using FunProject.Application.Data.Orders.Query.QueriesPlugins;
using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.Models;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Mapper;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class OrdersByFiltersTask : IOrdersByFiltersTask
    {
        private readonly IOrdersByFiltersQuery _ordersByFiltersQuery;
        private readonly IMapperAdapter _mapper;

        public OrdersByFiltersTask(IOrdersByFiltersQuery ordersByFiltersQuery, IMapperAdapter mapper)
        {
            _ordersByFiltersQuery = ordersByFiltersQuery;
            _mapper = mapper;
        }
        public IList<OrderDto> Get(OrderFiltersValuesModel filtersValues, IList<IBaseOrderQueryPlugin> plugins)
        {
            return _mapper.Map<IList<OrderDto>>(_ordersByFiltersQuery.Get(plugins, filtersValues));
        }
    }
}
