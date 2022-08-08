using FunProject.Application.Data.Products.Query;
using FunProject.Application.ProductsModule.Dtos;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Mapper;
using System.Collections.Generic;

namespace FunProject.Application.ProductsModule.WorkFlows.Tasks
{
    public class GetAllOutOfStockProductsTask : IGetAllOutOfStockProductsTask
    {
        private readonly IGetAllOutOfStockProductsQuery _getAllOutOfStockProductsQuery;
        private readonly IMapperAdapter _mapper;

        public GetAllOutOfStockProductsTask(IGetAllOutOfStockProductsQuery getAllOutOfStockProductsQuery, IMapperAdapter mapper)
        {
            _getAllOutOfStockProductsQuery = getAllOutOfStockProductsQuery;
            _mapper = mapper;
        }
        public IList<ProductDto> Get()
        {
            return _mapper.Map<IList<ProductDto>>(_getAllOutOfStockProductsQuery.Get());
        }
    }
}
