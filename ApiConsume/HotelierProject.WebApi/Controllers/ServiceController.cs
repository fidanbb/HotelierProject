using AutoMapper;
using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DtoLayer.ServiceDtos;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;
        private readonly IMapper _mapper;

        public ServiceController(IServiceService serviceService, IMapper mapper)
        {
            _serviceService = serviceService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            return Ok(_mapper.Map<List<ResultServiceDto>>(await _serviceService.TGetList()));
        }

        [HttpPost]

        public async Task<IActionResult> AddService(CreateServiceDto createServiceDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var value = _mapper.Map<Service>(createServiceDto);

            await _serviceService.TInsert(value);

            return Ok("Service added successfully");
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteService(int id)
        {
            var value = await _serviceService.TGetByID(id);

            await _serviceService.TDelete(value);

            return Ok("Service deleted successfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var value = _mapper.Map<Service>(updateServiceDto);

            await _serviceService.TUpdate(value);

            return Ok("Service updated successfully");
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetService(int id)
        {
            return Ok(_mapper.Map<GetServiceDto>(await _serviceService.TGetByID(id)));
        }
    }
}
