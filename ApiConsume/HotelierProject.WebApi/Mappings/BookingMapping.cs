using AutoMapper;
using HotelierProject.DtoLayer.AboutDtos;
using HotelierProject.DtoLayer.BookingDtos;
using HotelierProject.EntityLayer.Concrete;

namespace HotelierProject.WebApi.Mappings
{
    public class BookingMapping:Profile
    {
        public BookingMapping()
        {
           CreateMap<Booking,ResultBookingDto>().ReverseMap();
           CreateMap<Booking,CreateBookingDto>().ReverseMap();
           CreateMap<Booking,UpdateBookingDto>().ReverseMap();
           CreateMap<Booking,GetBookingDto>().ReverseMap();
        }
    }
}
