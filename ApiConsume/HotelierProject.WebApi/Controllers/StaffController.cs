using AutoMapper;
using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DtoLayer.StaffDtos;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IMapper _mapper;

        public StaffController(IStaffService staffService, IMapper mapper)
        {
            _staffService = staffService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> StaffList()
        {
            return Ok(_mapper.Map<List<ResultStaffDto>>(await _staffService.TGetList()));
        }

        [HttpPost]

        public async Task<IActionResult> AddStaff(CreateStaffDto createStaffDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var value = _mapper.Map<Staff>(createStaffDto);

            await _staffService.TInsert(value);

            return Ok("Staff added successfully");
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteStaff(int id)
        {
            var value = await _staffService.TGetByID(id);

            await _staffService.TDelete(value); 

            return Ok("Staff deleted successfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStaff(UpdateStaffDto updateStaffDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var value = _mapper.Map<Staff>(updateStaffDto);

            await _staffService.TUpdate(value);

            return Ok("Staff updated successfully");
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetStaff(int id)
        {
            return Ok(_mapper.Map<GetStaffDto>(await _staffService.TGetByID(id)));
        }

        [HttpGet("Last4Staff")]
        public async Task<IActionResult> Last4Staff()
        {
            var values = _mapper.Map<List<ResultStaffDto>>(await _staffService.TGetList());
            return Ok(values);
        }
    }
}
