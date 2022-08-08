using FunProject.Domain.Enums;
using FunProject.Domain.Models;

namespace FunProject.Application.OrdersModule.Models
{
    public class OrderFiltersValuesModel
    {
        public UserType? CustomerType { get; set; }
        public string CustomerNameSearchValue { get; set; }
        public string ProductNameSearchValue { get; set; }
        public DateRange DateRange { get; set; }
    }
}
