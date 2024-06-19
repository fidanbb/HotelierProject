using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.Layout
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
