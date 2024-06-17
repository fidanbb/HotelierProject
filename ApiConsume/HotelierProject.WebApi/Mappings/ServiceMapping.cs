using AutoMapper;
using HotelierProject.DtoLayer.ServiceDtos;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.WebApi.Mappings
{
    public class ServiceMapping:Profile
    {
        public ServiceMapping()
        {
            CreateMap<Service,ResultServiceDto>().ReverseMap();
            CreateMap<Service,CreateServiceDto>().ReverseMap();
            CreateMap<Service,UpdateServiceDto>().ReverseMap();
            CreateMap<Service,GetServiceDto>().ReverseMap();
        }
    }
}
