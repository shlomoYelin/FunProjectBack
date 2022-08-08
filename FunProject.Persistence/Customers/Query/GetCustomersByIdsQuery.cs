using FunProject.Application.Data.Customers.Query;
using FunProject.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FunProject.Persistence.Customers.Query
{
    public class GetCustomersByIdsQuery : IGetCustomersByIdsQuery
    {
        private readonly AppDbContext _appDbContext;

        public GetCustomersByIdsQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IList<Customer> Get(IList<int> ids)
        {
            return _appDbContext.Customers
                .Where(c => ids.Contains(c.Id))
                .ToList();
        }
    }
}
