using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Application.Data.Customers.Query
{
    public interface IISCustomerPhoneNumberExistsQuery
    {
        bool IsExists(string phoneNumber);
    }
}
