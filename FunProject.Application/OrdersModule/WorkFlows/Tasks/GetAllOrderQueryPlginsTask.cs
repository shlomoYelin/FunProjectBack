using FunProject.Application.Data.Orders.Query.QueriesPlugins;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class GetAllOrderQueryPlginsTask : IGetAllOrderQueryPlginsTask
    {
        private readonly IFilterOrdersByCustomerNameSearchValue _filterOrdersByCustomerNameSearchValue;
        private readonly IFilterOrdersByCustomerType _filterOrdersByCustomerType;
        private readonly IFilterOrdersByDateRange _filterOrdersByDateRange;
        private readonly IFilterOrdersByProductNameSearchValue _filterOrdersByProductNameSearchValue;

        public GetAllOrderQueryPlginsTask(
            IFilterOrdersByCustomerNameSearchValue filterOrdersByCustomerNameSearchValue,
            IFilterOrdersByCustomerType filterOrdersByCustomerType,
            IFilterOrdersByDateRange filterOrdersByDateRange,
            IFilterOrdersByProductNameSearchValue filterOrdersByProductNameSearchValue
            )
        {
            _filterOrdersByCustomerNameSearchValue = filterOrdersByCustomerNameSearchValue;
            _filterOrdersByCustomerType = filterOrdersByCustomerType;
            _filterOrdersByDateRange = filterOrdersByDateRange;
            _filterOrdersByProductNameSearchValue = filterOrdersByProductNameSearchValue;
        }

        public IList<IBaseOrderQueryPlugin> Get()
        {
            return new List<IBaseOrderQueryPlugin>()
            {
                _filterOrdersByDateRange,
                _filterOrdersByCustomerType,
                _filterOrdersByCustomerNameSearchValue,
                _filterOrdersByProductNameSearchValue
            };
        }
    }
}
