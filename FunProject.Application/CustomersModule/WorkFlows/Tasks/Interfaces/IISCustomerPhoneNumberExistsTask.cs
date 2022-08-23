using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces
{
    public interface IISCustomerPhoneNumberExistsTask
    {
        bool IsExists(string phoneNumber);
    }
}
