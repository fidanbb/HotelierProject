using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.Layout
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
