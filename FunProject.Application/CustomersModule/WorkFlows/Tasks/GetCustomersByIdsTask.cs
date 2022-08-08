using FunProject.Application.CustomersModule.Dtos;
using FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.Data.Customers.Query;
using FunProject.Domain.Mapper;
using System.Collections.Generic;

namespace FunProject.Application.CustomersModule.WorkFlows.Tasks
{
    public class GetCustomersByIdsTask : IGetCustomersByIdsTask
    {
        private readonly IGetCustomersByIdsQuery _getCustomersByIdsQuery;
        private readonly IMapperAdapter _mapper;

        public GetCustomersByIdsTask(IGetCustomersByIdsQuery getCustomersByIdsQuery, IMapperAdapter mapper)
        {
            _getCustomersByIdsQuery = getCustomersByIdsQuery;
            _mapper = mapper;
        }
        public IList<CustomerDto> Get(IList<int> ids)
        {
            return _mapper.Map<IList<CustomerDto>>(_getCustomersByIdsQuery.Get(ids));
        }
    }
}
