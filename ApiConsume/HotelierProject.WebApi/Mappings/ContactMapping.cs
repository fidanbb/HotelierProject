using AutoMapper;
using HotelierProject.DtoLayer.ContactDtos;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.WebApi.Mappings
{
    public class ContactMapping:Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact,ResultContactDto>().ReverseMap();
            CreateMap<Contact,CreateContactDto>().ReverseMap();
            CreateMap<Contact,UpdateContactDto>().ReverseMap();
            CreateMap<Contact,GetContactDto>().ReverseMap();
        }
    }
}
