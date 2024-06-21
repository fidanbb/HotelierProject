using AutoMapper;
using HotelierProject.DtoLayer.SendMessageDtos;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.WebApi.Mappings
{
    public class SendMessageMapping:Profile
    {
        public SendMessageMapping()
        {
            CreateMap<SendMessage,ResultSendMessageDto>().ReverseMap();
            CreateMap<SendMessage,CreateSendMessageDto>().ReverseMap();
            CreateMap<SendMessage,GetSendMessageDto>().ReverseMap();
        }
    }
}
