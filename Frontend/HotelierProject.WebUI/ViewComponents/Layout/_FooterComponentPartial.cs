using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.Layout
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
