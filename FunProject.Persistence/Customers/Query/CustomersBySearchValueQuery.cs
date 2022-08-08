using FunProject.Application.Data.Customers.Query;
using FunProject.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Persistence.Customers.Query
{
    public class CustomersBySearchValueQuery : ICustomersBySearchValueQuery
    {
        private readonly AppDbContext _appDbContext;

        public CustomersBySearchValueQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IList<Customer> Get(string searchValue)
        {
            return _appDbContext.Customers
                .Where(c => c.FirstName.Contains(searchValue) || c.LastName.Contains(searchValue))
                .ToList();
        }
    }
}
