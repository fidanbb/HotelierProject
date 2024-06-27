using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}
