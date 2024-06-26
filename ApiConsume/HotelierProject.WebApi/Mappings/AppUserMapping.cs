using AutoMapper;
using HotelierProject.DtoLayer.AppUserDto;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.WebApi.Mappings
{
    public class AppUserMapping:Profile
    {
        public AppUserMapping()
        {
            CreateMap<AppUser,ResultAppUserDto>().ReverseMap();
            CreateMap<AppUser,ResultAppUserListDto>().ReverseMap();
            CreateMap<AppUser,ResultAppUserWithWorkLocationDto>().ForMember(dest => dest.WorkLocationName, opt => opt.MapFrom(src => src.WorkLocation.WorkLocationName)).ReverseMap();
        }
    }
}
