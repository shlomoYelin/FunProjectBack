﻿using FunProject.Application.Data.Orders.Command;
using FunProject.Domain.Entities;

namespace FunProject.Persistence.Orders.Command
{
    public class CreateOrderCommand : ICreateOrderCommand
    {
        private readonly AppDbContext _appDbContext;

        public CreateOrderCommand(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Create(Order order)
        {
            _ = _appDbContext.Orders.Add(order).Entity;
            _ = _appDbContext.SaveChanges();
        }
    }
}
