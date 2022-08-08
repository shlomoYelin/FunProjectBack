using FunProject.Application.ProductsModule.Dtos;

namespace FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces
{
    public interface IUpdateProductTask
    {
        void Update(ProductDto product);
    }
}
