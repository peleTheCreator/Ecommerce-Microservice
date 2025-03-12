using AutoMapper;
using Ecommerce.UserMS.Domain.Entities;
using Ecommerce.UserMS.Domain.Model.ResponseDto;


namespace Ecommerce.UserMS.Domain.Mapper;

public class ApplicationUserToUserDTOMappingProfile : Profile
{
  public ApplicationUserToUserDTOMappingProfile()
  {
    CreateMap<ApplicationUser, UserDTO>()
      .ForMember(des => des.UserID, opt => opt.MapFrom(src => src.UserID))
      .ForMember(des => des.Email, opt => opt.MapFrom(src => src.Email))
      .ForMember(des => des.PersonName, opt => opt.MapFrom(src => src.PersonName))
      .ForMember(des => des.Gender, opt => opt.MapFrom(src => src.Gender));
  }
}