﻿using AutoMapper;
using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DtoLayer.BookingDtos;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingController(IBookingService bookingService, IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> BookingList()
        {
            return Ok(_mapper.Map<List<ResultBookingDto>>(await _bookingService.TGetList()));
        }

        [HttpPost]

        public async Task<IActionResult> AddBooking(CreateBookingDto createBookingDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var value = _mapper.Map<Booking>(createBookingDto);

            await _bookingService.TInsert(value);

            return Ok("Booking added successfully");
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteBooking(int id)
        {
            var value = await _bookingService.TGetByID(id);

            await _bookingService.TDelete(value);

            return Ok("Booking deleted successfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var value = _mapper.Map<Booking>(updateBookingDto);

            await _bookingService.TUpdate(value);

            return Ok("Booking updated successfully");
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetBooking(int id)
        {
            return Ok(_mapper.Map<GetBookingDto>(await _bookingService.TGetByID(id)));
        }
    }
}
