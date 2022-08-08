using FunProject.Application.Data.Products.Query;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.ProductsModule.Dtos;
using FunProject.Domain.Mapper;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class GetProductsByIdsTask : IGetProductsByIdsTask
    {
        private readonly IProductsByIdsQuery _productsByIdsQuery;
        private readonly IMapperAdapter _mapper;

        public GetProductsByIdsTask(IProductsByIdsQuery productsByIdsQuery, IMapperAdapter mapper)
        {
            _productsByIdsQuery = productsByIdsQuery;
            _mapper = mapper;
        }

        public IList<ProductDto> Get(IList<int> productsIds)
        {
            return _mapper.Map<IList<ProductDto>>(_productsByIdsQuery.Get(productsIds));
        }
    }
}
