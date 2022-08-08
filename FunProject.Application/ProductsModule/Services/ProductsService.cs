using FunProject.Domain.Models;
using System.Collections.Generic;
using FunProject.Application.ProductsModule.WorkFlows.Interfaces;
using FunProject.Application.ProductsModule.Services.Interfaces;
using FunProject.Application.ProductsModule.Dtos;

namespace FunProject.Application.ProductsModule.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IGetAllProductWorkFlow _getAllProductsWorkFlow;
        private readonly ICreateProductWorkFlow _createProductWorkFlow;
        private readonly IUpdateProductWorkFlow _updateProductWorkFlow;
        private readonly IDeleteProductWorkFlow _deleteProductWorkFlow;
        private readonly IGetProductsBySearchValueWorkFlow _getProductsBySearchValueWorkFlow;
        private readonly IProductIsInStockWprkFlow _productIsInStockWprkFlow;
        private readonly IGetOutOfStockProductsWorkFlow _getOutOfStockProductsWorkFlow;

        public ProductsService(
            IGetAllProductWorkFlow getAllProductsWorkFlow,
            ICreateProductWorkFlow createProductWorkFlow,
            IUpdateProductWorkFlow updateProductWorkFlow,
            IDeleteProductWorkFlow deleteProductWorkFlow,
            IGetProductsBySearchValueWorkFlow getProductsBySearchValueWorkFlow,
            IProductIsInStockWprkFlow productIsInStockWprkFlow,
            IGetOutOfStockProductsWorkFlow getOutOfStockProductsWorkFlow)
        {
            _getAllProductsWorkFlow = getAllProductsWorkFlow;
            _createProductWorkFlow = createProductWorkFlow;
            _updateProductWorkFlow = updateProductWorkFlow;
            _deleteProductWorkFlow = deleteProductWorkFlow;
            _getProductsBySearchValueWorkFlow = getProductsBySearchValueWorkFlow;
            _productIsInStockWprkFlow = productIsInStockWprkFlow;
            _getOutOfStockProductsWorkFlow = getOutOfStockProductsWorkFlow;
        }

        public IList<ProductDto> GetAllProducts()
        {
            return _getAllProductsWorkFlow.Get();
        }

        public IList<ProductDto> GetOutOfStock()
        {
            return _getOutOfStockProductsWorkFlow.Get();
        }

        public ActionStatusModel CreateProduct(ProductDto Product)
        {
            return _createProductWorkFlow.Create(Product);
        }

        public ActionStatusModel UpdateProduct(ProductDto Product)
        {
            return _updateProductWorkFlow.Update(Product);
        }

        public ActionStatusModel DeleteProduct(int id)
        {
            return _deleteProductWorkFlow.Delete(id);
        }

        public IList<ProductDto> GetProductsBySearchValue(string searchValue)
        {
            return _getProductsBySearchValueWorkFlow.Get(searchValue);
        }

        public int IsInStock(int productId, int quantity)
        {
            return _productIsInStockWprkFlow.IsInStock(productId, quantity);
        }
    }
}
