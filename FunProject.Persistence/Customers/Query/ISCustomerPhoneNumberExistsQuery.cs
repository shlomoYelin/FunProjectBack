using FunProject.Application.Data.Customers.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Persistence.Customers.Query
{
    public class ISCustomerPhoneNumberExistsQuery : IISCustomerPhoneNumberExistsQuery
    {
        private readonly AppDbContext _appDbContext;

        public ISCustomerPhoneNumberExistsQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public bool IsExists(string phoneNumber)
        {
            return _appDbContext.Customers.Any(c => c.Phone == phoneNumber);
        }
    }
}
