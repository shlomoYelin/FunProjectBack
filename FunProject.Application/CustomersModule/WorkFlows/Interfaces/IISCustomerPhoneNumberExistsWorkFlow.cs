using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Application.CustomersModule.WorkFlows.Interfaces
{
    public interface IISCustomerPhoneNumberExistsWorkFlow
    {
        bool IsExists(string phoneNumber);
    }
}
