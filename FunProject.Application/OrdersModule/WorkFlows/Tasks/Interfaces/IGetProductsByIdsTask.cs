using FunProject.Application.ProductsModule.Dtos;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IGetProductsByIdsTask
    {
        IList<ProductDto> Get(IList<int> productsIds);
    }
}
