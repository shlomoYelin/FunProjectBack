using FunProject.Application.CustomersModule.WorkFlows.Interfaces;
using FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Application.CustomersModule.WorkFlows
{
    public class ISCustomerPhoneNumberExistsWorkFlow : IISCustomerPhoneNumberExistsWorkFlow
    {
        private readonly IISCustomerPhoneNumberExistsTask _iSCustomerPhoneNumberExistsTask;

        public ISCustomerPhoneNumberExistsWorkFlow(IISCustomerPhoneNumberExistsTask iSCustomerPhoneNumberExistsTask)
        {
            _iSCustomerPhoneNumberExistsTask = iSCustomerPhoneNumberExistsTask;
        }

        public bool IsExists(string phoneNumber)
        {
            return _iSCustomerPhoneNumberExistsTask.IsExists(phoneNumber);
        }
    }
}
