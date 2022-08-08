using AutoMapper;
using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.Models;
using FunProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Infrastructure.Mapper.Mapping
{
    public class OrderStringsMap : Profile
    {
        public OrderStringsMap()
        {
            _ = CreateMap<OrderDto, OrderStringsModel>()
                 .ForMember(d => d.Id, s => s.MapFrom(x => x.Id.ToString()))
                 .ForMember(d => d.CustomerId, s => s.MapFrom(x => x.CustomerId.ToString()))
                 .ForMember(d => d.Date, s => s.MapFrom(x => x.Date.ToString("dd/MM/yyyy")))
                 .ForMember(d => d.CustomerType, s => s.MapFrom(x => x.CustomerType.ToString()))
                 .ForMember(d => d.FirstName, s => s.MapFrom(x => x.FirstName))
                 .ForMember(d => d.LastName, s => s.MapFrom(x => x.LastName));
        }
    }
}
