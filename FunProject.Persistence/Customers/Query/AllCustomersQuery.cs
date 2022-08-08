﻿using FunProject.Application.Data.Customers.Query;
using FunProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FunProject.Persistence.Customers.Query
{
    public class AllCustomersQuery : IAllCustomersQuery
    {
        private readonly AppDbContext _appDbContext;

        public AllCustomersQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IList<Customer>> Get()
        {
            return await _appDbContext.Customers.ToListAsync();
        }
    }
}
