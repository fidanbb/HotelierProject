using AutoMapper;
using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DtoLayer.RoomDtos;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public RoomController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> RoomList()
        {
            return Ok(_mapper.Map<List<ResultRoomDto>>(await _roomService.TGetList()));
        }

        [HttpPost]

        public async Task<IActionResult> AddRoom(CreateRoomDto createRoomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var value = _mapper.Map<Room>(createRoomDto);

            await _roomService.TInsert(value);

            return Ok("Room added successfully");
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteRoom(int id)
        {
            var value = await _roomService.TGetByID(id);

            await _roomService.TDelete(value);

            return Ok("Room deleted successfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRoom(UpdateRoomDto updateRoomDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var value = _mapper.Map<Room>(updateRoomDto);

            await _roomService.TUpdate(value);

            return Ok("Room updated successfully");
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetRoom(int id)
        {
            return Ok(_mapper.Map<GetRoomDto>(await _roomService.TGetByID(id)));
        }
    }
}
