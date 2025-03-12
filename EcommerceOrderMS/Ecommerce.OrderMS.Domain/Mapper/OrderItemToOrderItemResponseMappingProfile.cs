using AutoMapper;
using Ecommerce.OrderMS.Domain.Entities;
using Ecommerce.OrderMS.Domain.Model;

namespace Ecommerce.OrderMS.Domain.Mapper;

public class OrderItemToOrderItemResponseMappingProfile : Profile
{
  public OrderItemToOrderItemResponseMappingProfile()
  {
    CreateMap<OrderItem, OrderItemResponse>()
      .ForMember(dest => dest.ProductID, opt => opt.MapFrom(src => src.ProductID))
      .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice))
      .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
      .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.TotalPrice));
  }
}