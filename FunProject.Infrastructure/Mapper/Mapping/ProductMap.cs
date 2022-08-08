using AutoMapper;
using FunProject.Application.ProductsModule.Dtos;
using FunProject.Domain.Entities;

namespace FunProject.Infrastructure.Mapper.Mapping
{
    public class ProductMap : Profile
    {
        public ProductMap()
        {
            _ = CreateMap<Product, ProductDto>()
                .ForMember(d => d.Id, s => s.MapFrom(x => x.Id))
                .ForMember(d => d.Description, s => s.MapFrom(x => x.Description))
                .ForMember(d => d.Quantity, s => s.MapFrom(x => x.Quantity))
                .ForMember(d => d.Price, s => s.MapFrom(x => x.Price));

            _ = CreateMap<ProductDto, Product>()
                .ForMember(d => d.Id, s => s.MapFrom(x => x.Id))
                .ForMember(d => d.Description, s => s.MapFrom(x => x.Description))
                .ForMember(d => d.Quantity, s => s.MapFrom(x => x.Quantity))
                .ForMember(d => d.Price, s => s.MapFrom(x => x.Price));
        }
    }
}
