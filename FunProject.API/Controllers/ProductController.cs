using FunProject.Application.ProductsModule.Dtos;
using FunProject.Application.ProductsModule.Services.Interfaces;
using FunProject.Domain.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FunProject.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public IList<ProductDto> GetAllProducts()
        {
            return _productsService.GetAllProducts();
        }

        [HttpGet]
        public IList<ProductDto> GetOutOfStockProducts()
        {
            return _productsService.GetOutOfStock();
        }

        [HttpGet("{searchValue}")]
        public IList<ProductDto> GetProductsBySearchValue(string searchValue)
        {
            return _productsService.GetProductsBySearchValue(searchValue);
        }

        // GET api/<ProductController>/1/2
        [HttpGet("{id}/{quantity}")]
        public int IsInStock(int id, int quantity)
        {
            return _productsService.IsInStock(id, quantity);
        }

        // POST api/<ProductController>
        [HttpPost]
        public ActionStatusModel CreateProduct([FromBody] ProductDto product)
        {
            return _productsService.CreateProduct(product);
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public ActionStatusModel UpdateProduct([FromBody] ProductDto product)
        {
            return _productsService.UpdateProduct(product);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public ActionStatusModel DeleteProduct(int id)
        {
            return _productsService.DeleteProduct(id);
        }
    }
}
