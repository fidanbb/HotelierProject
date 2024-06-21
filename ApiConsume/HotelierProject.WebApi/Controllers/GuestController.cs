using AutoMapper;
using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DtoLayer.GuestDtos;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;
        private readonly IMapper _mapper;

        public GuestController(IGuestService guestService, IMapper mapper)
        {
            _guestService = guestService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GuestList()
        {
            return Ok(_mapper.Map<List<ResultGuestDto>>(await _guestService.TGetList()));
        }

        [HttpPost]

        public async Task<IActionResult> AddGuest(CreateGuestDto createGuestDto)
        {
          
            var value = _mapper.Map<Guest>(createGuestDto);

            await _guestService.TInsert(value);

            return Ok("Guest added successfully");
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteGuest(int id)
        {
            var value = await _guestService.TGetByID(id);

            await _guestService.TDelete(value);

            return Ok("Guest deleted successfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateGuest(UpdateGuestDto updateGuestDto)
        {
        

            var value = _mapper.Map<Guest>(updateGuestDto);

            await _guestService.TUpdate(value);

            return Ok("Guest updated successfully");
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetGuest(int id)
        {
            return Ok(_mapper.Map<GetGuestDto>(await _guestService.TGetByID(id)));
        }
    }
}
