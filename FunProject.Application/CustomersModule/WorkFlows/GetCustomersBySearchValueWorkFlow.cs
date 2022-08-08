using FunProject.Application.CustomersModule.Dtos;
using FunProject.Application.CustomersModule.WorkFlows.Interfaces;
using FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces;
using System.Collections.Generic;

namespace FunProject.Application.CustomersModule.WorkFlows
{
    public class GetCustomersBySearchValueWorkFlow : IGetCustomersBySearchValueWorkFlow
    {
        private readonly IGetCustomersBySearchValueTask _getCustomersBySearchValueTask;

        public GetCustomersBySearchValueWorkFlow(IGetCustomersBySearchValueTask getCustomersBySearchValueTask)
        {
            _getCustomersBySearchValueTask = getCustomersBySearchValueTask;
        }

        public IList<CustomerDto> Get(string searchValue)
        {
           return _getCustomersBySearchValueTask.Get(searchValue);
        }
    }
}
