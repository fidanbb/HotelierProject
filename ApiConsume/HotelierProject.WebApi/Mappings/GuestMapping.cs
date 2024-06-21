using AutoMapper;
using HotelierProject.DtoLayer.GuestDtos;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.WebApi.Mappings
{
    public class GuestMapping:Profile
    {
        public GuestMapping()
        {
            CreateMap<Guest,ResultGuestDto>().ReverseMap();
            CreateMap<Guest,CreateGuestDto>().ReverseMap();
            CreateMap<Guest,UpdateGuestDto>().ReverseMap();
            CreateMap<Guest,GetGuestDto>().ReverseMap();
        }
    }
}
