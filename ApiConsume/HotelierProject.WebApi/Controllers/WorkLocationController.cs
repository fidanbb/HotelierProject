using AutoMapper;
using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DtoLayer.WorkLocationDtos;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkLocationController : ControllerBase
    {
        private readonly IWorkLocationService _workLocationService;
        private readonly IMapper _mapper;

        public WorkLocationController(IWorkLocationService workLocationService, IMapper mapper)
        {
            _workLocationService = workLocationService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> WorkLocationList()
        {
            return Ok(_mapper.Map<List<ResultWorkLocationDto>>(await _workLocationService.TGetList()));
        }

        [HttpPost]

        public async Task<IActionResult> AddWorkLocation(CreateWorkLocationDto createWorkLocationDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var value = _mapper.Map<WorkLocation>(createWorkLocationDto);

            await _workLocationService.TInsert(value);

            return Ok("WorkLocation added successfully");
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteWorkLocation(int id)
        {
            var value = await _workLocationService.TGetByID(id);

            await _workLocationService.TDelete(value);

            return Ok("WorkLocation deleted successfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateWorkLocation(UpdateWorkLocationDto updateWorkLocationDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var value = _mapper.Map<WorkLocation>(updateWorkLocationDto);

            await _workLocationService.TUpdate(value);

            return Ok("WorkLocation updated successfully");
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetWorkLocation(int id)
        {
            return Ok(_mapper.Map<GetWorkLocationDto>(await _workLocationService.TGetByID(id)));
        }
    }
}
