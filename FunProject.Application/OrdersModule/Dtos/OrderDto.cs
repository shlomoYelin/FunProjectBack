using FunProject.Domain.Attributes;
using FunProject.Domain.Enums;
using System;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.Dtos
{
    [ExcelHeaderStyle(Height = 20, Color = System.Drawing.KnownColor.Red, Bold = true)]
    public class OrderDto
    {
        [ExcelColumnStyle(Index = 1, Width = 10.5, Color = System.Drawing.KnownColor.Gold, Bold = false, Name = "Id")]
        public int Id { get; set; }

        [ExcelColumnStyle(Index = 2, Width = 10.5, Color = System.Drawing.KnownColor.Gold, Bold = false, Name = "Customer Id")]
        public int CustomerId { get; set; }

        public IList<ProductOrderDto> ProductOrders { get; set; }

        [ExcelColumnStyle(Index = 3, Width = 10.5, Color = System.Drawing.KnownColor.Gold, Bold = false, Name = "Payment")]
        public float Payment { get; set; }

        [ExcelColumnStyle(Index = 4, Width = 10.5, Color = System.Drawing.KnownColor.Gold, Bold = false, Name = "Date")]
        public DateTime Date { get; set; }

        [ExcelColumnStyle(Index = 5, Width = 10.5, Color = System.Drawing.KnownColor.Gold, Bold = false, Name = "First Name")]
        public string FirstName { get; set; }

        [ExcelColumnStyle(Index = 6, Width = 10.5, Color = System.Drawing.KnownColor.Gold, Bold = false, Name = "Last Name")]
        public string LastName { get; set; }

        [ExcelColumnStyle(Index = 7, Width = 10.5, Color = System.Drawing.KnownColor.Gold, Bold = false, Name = "Customer Type")]
        public UserType CustomerType { get; set; }
    }
}
