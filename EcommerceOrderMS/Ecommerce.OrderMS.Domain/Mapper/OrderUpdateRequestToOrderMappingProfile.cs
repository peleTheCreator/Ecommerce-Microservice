using AutoMapper;
using Ecommerce.OrderMS.Domain.Entities;
using Ecommerce.OrderMS.Domain.Model;

namespace Ecommerce.OrderMS.Domain.Mapper;

public class OrderUpdateRequestToOrderMappingProfile : Profile
{
  public OrderUpdateRequestToOrderMappingProfile()
  {
    CreateMap<OrderUpdateRequest, Order>()
      .ForMember(dest => dest.OrderID, opt => opt.MapFrom(src => src.OrderID))
      .ForMember(dest => dest.UserID, opt => opt.MapFrom(src => src.UserID))
      .ForMember(dest => dest.OrderDate, opt => opt.MapFrom(src => src.OrderDate))
      .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItems))
      .ForMember(dest => dest._id, opt => opt.Ignore())
      .ForMember(dest => dest.TotalBill, opt => opt.Ignore());
  }
}