using FunProject.Application.Data.Products.Query;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.ProductsModule.Dtos;
using FunProject.Domain.Mapper;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class GetProductsByOrderIdTask : IGetProductsByOrderIdTask
    {
        private readonly IProductsByOrderIdQuery _productsByOrderIdQuery;
        private readonly IMapperAdapter _mapper;

        public GetProductsByOrderIdTask(IProductsByOrderIdQuery productsByOrderIdQuery, IMapperAdapter mapper)
        {
            _productsByOrderIdQuery = productsByOrderIdQuery;
            _mapper = mapper;
        }

        public IList<ProductDto> Get(int orderId)
        {
            return _mapper.Map<IList<ProductDto>>(_productsByOrderIdQuery.Get(orderId));
        }
    }
}
