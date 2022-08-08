﻿using FunProject.Application.CustomersModule.Dtos;
using FunProject.Domain.Models;
using System.Collections.Generic;

namespace FunProject.Application.CustomersModule.Services.Interfaces
{
    public interface ICustomersService
    {
        IList<CustomerDto> GetAllCustomers();
        IList<CustomerDto> GetCustomersBySearchValue(string searchValue);
        ActionStatusModel CreateCustomer(CustomerDto customer);
        ActionStatusModel UpdateCustomer(CustomerDto customer);
        ActionStatusModel DeleteCustomer(int id);
    }
}