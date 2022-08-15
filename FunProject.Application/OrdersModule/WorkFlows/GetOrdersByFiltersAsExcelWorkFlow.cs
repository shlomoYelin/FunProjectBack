﻿using FunProject.Application.OrdersModule.Models;
using FunProject.Application.OrdersModule.WorkFlows.Interfaces;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.ExcelModule;
using FunProject.Domain.Mapper;
using System.Collections.Generic;
using System.IO;

namespace FunProject.Application.OrdersModule.WorkFlows
{
    public class GetOrdersByFiltersAsExcelWorkFlow : IGetOrdersByFiltersAsExcelWorkFlow
    {
        private readonly IGetAllOrderQueryPlginsTask _getAllOrderQueryPlginsTask;
        private readonly IOrdersByFiltersTask _ordersByFiltersTask;
        private readonly IExcelAdapter _excelAdapter;

        public GetOrdersByFiltersAsExcelWorkFlow(IGetAllOrderQueryPlginsTask getAllOrderQueryPlginsTask, IOrdersByFiltersTask ordersByFiltersTask, IExcelAdapter excelAdapter)
        {
            _getAllOrderQueryPlginsTask = getAllOrderQueryPlginsTask;
            _ordersByFiltersTask = ordersByFiltersTask;
            _excelAdapter = excelAdapter;
        }

        public MemoryStream Get(OrderFiltersValuesModel filtersValues)
        {
            var plagins = _getAllOrderQueryPlginsTask.Get();

            var orders = _ordersByFiltersTask.Get(filtersValues, plagins);

            return _excelAdapter.GenerateExcel(orders,"Orders");
        }
    }
}
