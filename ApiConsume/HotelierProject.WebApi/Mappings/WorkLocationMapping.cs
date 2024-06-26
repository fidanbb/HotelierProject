using AutoMapper;
using HotelierProject.DtoLayer.WorkLocationDtos;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.WebApi.Mappings
{
    public class WorkLocationMapping:Profile
    {
        public WorkLocationMapping()
        {
            CreateMap<WorkLocation,ResultWorkLocationDto>().ReverseMap();
            CreateMap<WorkLocation,CreateWorkLocationDto>().ReverseMap();
            CreateMap<WorkLocation,UpdateWorkLocationDto>().ReverseMap();
            CreateMap<WorkLocation,GetWorkLocationDto>().ReverseMap();
        }
    }
}
