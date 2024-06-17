using AutoMapper;
using HotelierProject.DtoLayer.SubscribeDtos;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.WebApi.Mappings
{
    public class SubscribeMapping:Profile
    {
        public SubscribeMapping()
        {
            CreateMap<Subscribe,ResultSubscribeDto>().ReverseMap();
            CreateMap<Subscribe,CreateSubscribeDto>().ReverseMap();
            CreateMap<Subscribe,UpdateSubscribeDto>().ReverseMap();
            CreateMap<Subscribe,GetSubscribeDto>().ReverseMap();
        }
    }
}
