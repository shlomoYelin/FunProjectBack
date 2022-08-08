using FunProject.Application.ProductsModule.Dtos;
using System.Collections.Generic;

namespace FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces
{
    public interface IGetProductsBySearchValueTask
    {
        IList<ProductDto> Get(string searchValue);
    }
}
