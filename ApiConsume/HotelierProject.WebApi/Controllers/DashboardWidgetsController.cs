using HotelierProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgetsController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IBookingService _bookingService;
        private readonly IAppUserService _appUserService;
        private readonly IRoomService _roomService;
        private readonly IGuestService _guestService;
        public DashboardWidgetsController(IStaffService staffService,
                                          IBookingService bookingService,
                                          IAppUserService appUserService,
                                          IRoomService roomService,
                                          IGuestService guestService)
        {
            _staffService = staffService;
            _bookingService = bookingService;
            _appUserService = appUserService;
            _roomService = roomService;
            _guestService = guestService;
        }

        [HttpGet("StaffCount")]
        public async Task<IActionResult> StaffCount()
        {
            var value =await _staffService.TGetStaffCount();
            return Ok(value);
        }

        [HttpGet("BookingCount")]
        public async Task<IActionResult> BookingCount()
        {
            var value = await _bookingService.TGetBookingCount();
            return Ok(value);
        }

        [HttpGet("AppUserCount")]
        public async Task<IActionResult> AppUserCount()
        {
            var value = await _appUserService.TAppUserCount();
            return Ok(value);
        }

        [HttpGet("GuestCount")]
        public async Task<IActionResult> GuestCount()
        {
            var value = await _guestService.TGetGuestCount();
            return Ok(value);
        }

        [HttpGet("RoomCount")]
        public async Task<IActionResult> RoomCount()
        {
            var value = await _roomService.TRoomCount();
            return Ok(value);
        }
    }
}
