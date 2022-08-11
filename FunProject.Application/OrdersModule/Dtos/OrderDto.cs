using FunProject.Domain.Atrributes;
using FunProject.Domain.Enums;
using FunProject.Domain.Models;
using System;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.Dtos
{
    public class OrderDto
    {
        [ExcelColumnStyle(Index = 1, Width = 10.5, Color =  System.Drawing.KnownColor.Blue, Bold = false, Name = "")]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public IList<ProductOrderDto> ProductOrders { get; set; }
        public float Payment { get; set; }
        public DateTime Date { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserType CustomerType { get; set; }
    }
}
