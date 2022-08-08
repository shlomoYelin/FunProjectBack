using FunProject.Application.CustomersModule.Dtos;
using FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.Data.Customers.Query;
using FunProject.Domain.Mapper;
using System.Collections.Generic;

namespace FunProject.Application.CustomersModule.WorkFlows.Tasks
{
    public class GetCustomersBySearchValueTask : IGetCustomersBySearchValueTask
    {
        private readonly ICustomersBySearchValueQuery _customersBySearchValueQuery;
        private readonly IMapperAdapter _mapper;

        public GetCustomersBySearchValueTask(ICustomersBySearchValueQuery customersBySearchValueQuery, IMapperAdapter mapper)
        {
            _customersBySearchValueQuery = customersBySearchValueQuery;
            _mapper = mapper;
        }

        public IList<CustomerDto> Get(string searchValue)
        {
            return _mapper.Map<IList<CustomerDto>>(_customersBySearchValueQuery.Get(searchValue));
        }
    }
}
