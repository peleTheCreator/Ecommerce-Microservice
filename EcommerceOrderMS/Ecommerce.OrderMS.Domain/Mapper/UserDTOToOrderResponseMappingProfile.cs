using AutoMapper;
using Ecommerce.OrderMS.Domain.Model;

namespace Ecommerce.OrderMS.Domain.Mapper;

public class UserDTOToOrderResponseMappingProfile : Profile
{
  public UserDTOToOrderResponseMappingProfile()
  {
    CreateMap<UserDTO, OrderResponse>()
      .ForMember(dest => dest.UserPersonName, opt => opt.MapFrom(src => src.PersonName))
      .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));
  }
}