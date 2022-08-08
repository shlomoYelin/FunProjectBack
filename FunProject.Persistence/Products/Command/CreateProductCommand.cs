﻿using FunProject.Application.Data.Products.Command;
using FunProject.Domain.Entities;

namespace FunProject.Persistence.Products.Command
{
    public class CreateProductCommand : ICreateProductCommand
    {
        private readonly AppDbContext _appDbContext;

        public CreateProductCommand(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Create(Product product)
        {
            _ = _appDbContext.Products.Add(product);
            _ = _appDbContext.SaveChangesAsync();
        }
    }
}
