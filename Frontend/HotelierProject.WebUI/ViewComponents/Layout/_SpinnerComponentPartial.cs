using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.Layout
{
    public class _SpinnerComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
