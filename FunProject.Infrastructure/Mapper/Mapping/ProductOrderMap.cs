using AutoMapper;
using FunProject.Application.OrdersModule.Dtos;
using FunProject.Domain.Entities;

namespace FunProject.Infrastructure.Mapper.Mapping
{
    public class ProductOrderMap : Profile
    {
        public ProductOrderMap()
        {
            _ = CreateMap<ProductOrder, ProductOrderDto>()
                .ForMember(d => d.Id, s => s.MapFrom(x => x.Id))
                .ForMember(d => d.ProductId, s => s.MapFrom(x => x.ProductId))
                .ForMember(d => d.OrderId, s => s.MapFrom(x => x.OrderId))
                .ForMember(d => d.Quantity, s => s.MapFrom(x => x.Quantity))
                .ForMember(d => d.ProductDescription, s => s.MapFrom(x => x.Product.Description));

            _ = CreateMap<ProductOrderDto, ProductOrder>()
                 .ForMember(d => d.Id, s => s.MapFrom(x => x.Id))
                 .ForMember(d => d.ProductId, s => s.MapFrom(x => x.ProductId))
                 .ForMember(d => d.OrderId, s => s.MapFrom(x => x.OrderId))
                 .ForMember(d => d.Quantity, s => s.MapFrom(x => x.Quantity));
        }
    }
}
