using AutoMapper;
using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DtoLayer.SubscribeDtos;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;
        private readonly IMapper _mapper;

        public SubscribeController(ISubscribeService subscribeService, IMapper mapper)
        {
            _subscribeService = subscribeService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> SubscribeList()
        {
            return Ok(_mapper.Map<List<ResultSubscribeDto>>(await _subscribeService.TGetList()));
        }

        [HttpPost]

        public async Task<IActionResult> AddSubscribe(CreateSubscribeDto createSubscribeDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var value = _mapper.Map<Subscribe>(createSubscribeDto);

            await _subscribeService.TInsert(value);

            return Ok("Subscribe added successfully");
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteSubscribe(int id)
        {
            var value = await _subscribeService.TGetByID(id);

            await _subscribeService.TDelete(value);

            return Ok("Subscribe deleted successfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSubscribe(UpdateSubscribeDto updateSubscribeDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var value = _mapper.Map<Subscribe>(updateSubscribeDto);

            await _subscribeService.TUpdate(value);

            return Ok("Subscribe updated successfully");
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetSubscribe(int id)
        {
            return Ok(_mapper.Map<GetSubscribeDto>(await _subscribeService.TGetByID(id)));
        }
    }
}
