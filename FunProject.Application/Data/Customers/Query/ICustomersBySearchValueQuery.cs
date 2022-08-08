using FunProject.Domain.Entities;
using System.Collections.Generic;

namespace FunProject.Application.Data.Customers.Query
{
    public interface ICustomersBySearchValueQuery
    {
        IList<Customer> Get(string searchValue);
    }
}
