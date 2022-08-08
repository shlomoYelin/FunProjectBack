using FunProject.Domain.Entities;
using System.Collections.Generic;

namespace FunProject.Application.Data.Customers.Query
{
    public interface IGetCustomersByIdsQuery
    {
        IList<Customer> Get(IList<int> ids);
    }
}
