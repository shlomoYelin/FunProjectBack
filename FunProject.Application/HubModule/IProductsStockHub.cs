using FunProject.Application.ProductsModule.Dtos;
using System.Collections.Generic;


namespace FunProject.Application.HubModule
{
    public interface IProductsStockHub
    {
        void SendUpdate(IList<ProductDto> products);
    }
}
