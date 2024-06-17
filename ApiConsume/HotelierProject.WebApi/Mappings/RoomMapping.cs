using AutoMapper;
using HotelierProject.DtoLayer.RoomDtos;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.WebApi.Mappings
{
    public class RoomMapping:Profile
    {
        public RoomMapping()
        {
            CreateMap<Room, ResultRoomDto>().ReverseMap();
            CreateMap<Room, CreateRoomDto>().ReverseMap();
            CreateMap<Room, UpdateRoomDto>().ReverseMap();
            CreateMap<Room, GetRoomDto>().ReverseMap();
        }
    }
}
