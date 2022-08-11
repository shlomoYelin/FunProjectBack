using FunProject.Domain.Atrributes;
using FunProject.Domain.Entities;

namespace FunProject.Application.OrdersModule.Models
{
    public class OrderStringsModel
    {
        public string Id { get; set; }
        [DisplaydName("Customer id")]
        public string CustomerId { get; set; }
        public string Payment { get; set; }
        public string Date { get; set; }
        [DisplaydName("First name")]
        public string FirstName { get; set; }
        [DisplaydName("Last name")]
        public string LastName { get; set; }
        [DisplaydName("Customer type")]
        public string CustomerType { get; set; }
        [DisplaydName("Customer type")]
        public Order MyProperty { get; set; }
    }
}
