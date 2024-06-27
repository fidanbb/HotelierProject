using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    
}
