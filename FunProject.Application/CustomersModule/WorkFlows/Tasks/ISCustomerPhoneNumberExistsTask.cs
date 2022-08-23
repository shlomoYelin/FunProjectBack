using FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.Data.Customers.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Application.CustomersModule.WorkFlows.Tasks
{
    public class ISCustomerPhoneNumberExistsTask : IISCustomerPhoneNumberExistsTask
    {
        private readonly IISCustomerPhoneNumberExistsQuery _iSCustomerPhoneNumberExistsQuery;

        public ISCustomerPhoneNumberExistsTask(IISCustomerPhoneNumberExistsQuery iSCustomerPhoneNumberExistsQuery)
        {
            _iSCustomerPhoneNumberExistsQuery = iSCustomerPhoneNumberExistsQuery;
        }

        public bool IsExists(string phoneNumber)
        {
            return _iSCustomerPhoneNumberExistsQuery.IsExists(phoneNumber);
        }
    }
}
