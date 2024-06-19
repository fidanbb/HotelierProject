using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.Booking
{
    public class _BookingCoverComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
