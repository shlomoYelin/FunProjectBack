using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.Models;
using FunProject.Application.OrdersModule.Services.Interfaces;
using FunProject.Domain.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FunProject.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrdersService _ordersService;

        public OrderController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }

        [HttpPost]
        public IActionResult ExportToExcel([FromBody] OrderFiltersValuesModel filtersValues)
        {
            return File(
                _ordersService.GetOrdersByFiltersAsExcel(filtersValues),
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                "orders.xlsx"
                );
        }

        [HttpPost]
        public IList<OrderDto> GetOrdersByFilters([FromBody] OrderFiltersValuesModel filtersValues)
        {
            return _ordersService.GetOrdersByFilters(filtersValues);
        }

        [HttpGet("{id}")]
        public OrderDto GetOrder(int id)
        {
            return _ordersService.GetOrder(id);
        }

        [HttpGet("{year}")]
        public List<TotalMonthlyOrdersModel> GetTotalMonthlyOrdersByYear(int year)
        {
            return _ordersService.GetTotalMonthlyOrdersByYear(year);
        }

        // POST api/<OrderController>
        [HttpPost]
        public ActionStatusModel CreateOrder([FromBody] OrderDto order)
        {
            return _ordersService.CreateOrder(order);
        }

        [HttpPut]
        public ActionStatusModel UpdateOrder([FromBody] OrderDto order)
        {
            return _ordersService.UpdateOrder(order);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public ActionStatusModel DeleteOrder(int id)
        {
            return _ordersService.DeleteOrder(id);
        }
    }
}
