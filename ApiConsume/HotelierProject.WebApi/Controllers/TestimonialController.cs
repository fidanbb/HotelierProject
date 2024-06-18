using AutoMapper;
using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DtoLayer.TestimonialDtos;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            return Ok(_mapper.Map<List<ResultTestimonialDto>>(await _testimonialService.TGetList()));
        }

        [HttpPost]

        public async Task<IActionResult> AddTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var value = _mapper.Map<Testimonial>(createTestimonialDto);

            await _testimonialService.TInsert(value);

            return Ok("Testimonial added successfully");
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            var value = await _testimonialService.TGetByID(id);

            await _testimonialService.TDelete(value);

            return Ok("Testimonial deleted successfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var value = _mapper.Map<Testimonial>(updateTestimonialDto);

            await _testimonialService.TUpdate(value);

            return Ok("Testimonial updated successfully");
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetTestimonial(int id)
        {
            return Ok(_mapper.Map<GetTestimonialDto>(await _testimonialService.TGetByID(id)));
        }
    }
}
