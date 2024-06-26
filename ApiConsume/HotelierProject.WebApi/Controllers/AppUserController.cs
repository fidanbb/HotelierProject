using AutoMapper;
using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DtoLayer.AppUserDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;

        public AppUserController(IAppUserService appUserService, IMapper mapper)
        {
            _appUserService = appUserService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> AppUserList()
        {
            var values = _mapper.Map<List<ResultAppUserListDto>>(await _appUserService.TGetList());
            return Ok(values);
        }

        [HttpGet("UserListWithWorkLocation")]
        public async Task<IActionResult> UserListWithWorkLocation()
        {
            var values = _mapper.Map<List<ResultAppUserWithWorkLocationDto>>(await _appUserService.TUserListWithWorkLocations());
            return Ok(values);
        }

    }
}
