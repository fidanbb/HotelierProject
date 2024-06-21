using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.Contact
{
    public class _ContactCoverComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
