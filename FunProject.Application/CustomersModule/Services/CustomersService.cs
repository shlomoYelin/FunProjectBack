using FunProject.Application.CustomersModule.Dtos;
using FunProject.Application.CustomersModule.Services.Interfaces;
using FunProject.Application.CustomersModule.WorkFlows.Interfaces;
using FunProject.Domain.Models;
using System.Collections.Generic;

namespace FunProject.Application.CustomersModule.Services
{
    public class CustomersService : ICustomersService
    {
        private readonly IGetAllCustomersWorkFlow _getAllCustomersWorkFlow;
        private readonly ICreateCustomerWorkFlow _createCustomerWorkFlow;
        private readonly IUpdateCustomerWorkFlow _updateCustomerWorkFlow;
        private readonly IDeleteCustomerWorkFlow _deleteCustomerWorkFlow;
        private readonly IGetCustomersBySearchValueWorkFlow _getCustomersBySearchValueWorkFlow;
        public CustomersService(
            IGetAllCustomersWorkFlow getAllCustomersWorkFlow,
            ICreateCustomerWorkFlow createCustomerWorkFlow,
            IUpdateCustomerWorkFlow updateCustomerWorkFlow,
            IDeleteCustomerWorkFlow deleteCustomerWorkFlow,
            IGetCustomersBySearchValueWorkFlow getCustomersBySearchValueWorkFlow)
        {
            _getAllCustomersWorkFlow = getAllCustomersWorkFlow;
            _createCustomerWorkFlow = createCustomerWorkFlow;
            _updateCustomerWorkFlow = updateCustomerWorkFlow;
            _deleteCustomerWorkFlow = deleteCustomerWorkFlow;
            _getCustomersBySearchValueWorkFlow = getCustomersBySearchValueWorkFlow;
        }

        public IList<CustomerDto> GetAllCustomers()
        {
            return _getAllCustomersWorkFlow.Get();
        }

        public ActionStatusModel CreateCustomer(CustomerDto customer)
        {
            return _createCustomerWorkFlow.Create(customer);
        }

        public ActionStatusModel UpdateCustomer(CustomerDto customer)
        {
            return _updateCustomerWorkFlow.Update(customer);
        }

        public ActionStatusModel DeleteCustomer(int id)
        {
            return _deleteCustomerWorkFlow.Delete(id);
        }

        public IList<CustomerDto> GetCustomersBySearchValue(string searchValue)
        {
            return _getCustomersBySearchValueWorkFlow.Get(searchValue);
        }
    }
}
