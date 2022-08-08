using FunProject.Application.ProductOrderModule.Dtos;
using FunProject.Domain.Atrributes;
using FunProject.Domain.Enums;
using System;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public IList<ProductOrderDto> ProductOrders { get; set; }
        public float Payment { get; set; }
        public DateTime Date { get; set; }

        public string DateStr => Date.ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserType CustomerType { get; set; }
    }
}
