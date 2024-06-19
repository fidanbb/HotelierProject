using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.Layout
{
    public class _ScriptsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
