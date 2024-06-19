using AutoMapper;
using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DtoLayer.AboutDtos;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            return Ok(_mapper.Map<List<ResultAboutDto>>(await _aboutService.TGetList()));
        }

        [HttpPost]

        public async Task<IActionResult> AddAbout(CreateAboutDto createAboutDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var value = _mapper.Map<About>(createAboutDto);

            await _aboutService.TInsert(value);

            return Ok("About added successfully");
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteAbout(int id)
        {
            var value = await _aboutService.TGetByID(id);

            await _aboutService.TDelete(value);

            return Ok("About deleted successfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var value = _mapper.Map<About>(updateAboutDto);

            await _aboutService.TUpdate(value);

            return Ok("About updated successfully");
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetAbout(int id)
        {
            return Ok(_mapper.Map<GetAboutDto>(await _aboutService.TGetByID(id)));
        }
    }
}
