using AutoMapper;
using HotelierProject.DtoLayer.StaffDtos;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.WebApi.Mappings
{
    public class StaffMapping:Profile
    {
        public StaffMapping()
        {
            CreateMap<Staff, ResultStaffDto>().ReverseMap();
            CreateMap<Staff, CreateStaffDto>().ReverseMap();
            CreateMap<Staff, UpdateStaffDto>().ReverseMap();
            CreateMap<Staff, GetStaffDto>().ReverseMap();
        }
    }
}
