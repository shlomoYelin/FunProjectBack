using FunProject.Application.ProductsModule.Dtos;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IGetProductsByOrderIdTask
    {
        IList<ProductDto> Get(int orderId);
    }
}
