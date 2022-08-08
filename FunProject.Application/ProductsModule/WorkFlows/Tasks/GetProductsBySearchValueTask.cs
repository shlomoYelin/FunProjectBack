using FunProject.Application.Data.Products.Query;
using FunProject.Application.ProductsModule.Dtos;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Mapper;
using System.Collections.Generic;

namespace FunProject.Application.ProductsModule.WorkFlows.Tasks
{
    public class GetProductsBySearchValueTask : IGetProductsBySearchValueTask
    {
        private readonly IGetProductsBySearchValueQuery _getProductsBySearchValueQuery;
        private readonly IMapperAdapter _mapper;

        public GetProductsBySearchValueTask(IGetProductsBySearchValueQuery getProductsBySearchValueQuery, IMapperAdapter mapper)
        {
            _getProductsBySearchValueQuery = getProductsBySearchValueQuery;
            _mapper = mapper;
        }

        public IList<ProductDto> Get(string searchValue)
        {
            return _mapper.Map<IList<ProductDto>>(_getProductsBySearchValueQuery.Get(searchValue));
        }
    }
}
