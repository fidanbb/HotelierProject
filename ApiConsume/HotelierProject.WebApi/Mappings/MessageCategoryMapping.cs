using AutoMapper;
using HotelierProject.DtoLayer.MessageCategoryDtos;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.WebApi.Mappings
{
    public class MessageCategoryMapping:Profile
    {
        public MessageCategoryMapping()
        {
            CreateMap<MessageCategory,ResultMessageCategoryDto>().ReverseMap();
            CreateMap<MessageCategory,CreateMessageCategoryDto>().ReverseMap();
            CreateMap<MessageCategory,UpdateMessageCategoryDto>().ReverseMap();
            CreateMap<MessageCategory,GetMessageCategoryDto>().ReverseMap();
        }
    }
}
