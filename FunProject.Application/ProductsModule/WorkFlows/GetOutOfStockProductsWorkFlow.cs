using FunProject.Application.ProductsModule.Dtos;
using FunProject.Application.ProductsModule.WorkFlows.Interfaces;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;
using System.Collections.Generic;

namespace FunProject.Application.ProductsModule.WorkFlows
{
    public class GetOutOfStockProductsWorkFlow : IGetOutOfStockProductsWorkFlow
    {
        private readonly IGetAllOutOfStockProductsTask _getAllOutOfStockProductsTask;

        public GetOutOfStockProductsWorkFlow(IGetAllOutOfStockProductsTask getAllOutOfStockProductsTask)
        {
            _getAllOutOfStockProductsTask = getAllOutOfStockProductsTask;
        }

        public IList<ProductDto> Get()
        {
            return _getAllOutOfStockProductsTask.Get();
        }
    }
}
