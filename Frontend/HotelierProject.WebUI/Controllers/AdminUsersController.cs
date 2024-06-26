using HotelierProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelierProject.WebUI.Controllers
{
    public class AdminUsersController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly UserManager<AppUser>_userManager;
        public AdminUsersController(IHttpClientFactory httpClientFactory, UserManager<AppUser> userManager)
        {
            _httpClientFactory = httpClientFactory;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }

        public async Task<IActionResult> UserList()
        {
            //var client = _httpClientFactory.CreateClient();
            //var responseMessage = await client.GetAsync("http://localhost:3523/api/AppUser");
            //if (responseMessage.IsSuccessStatusCode)
            //{
            //    var jsonData = await responseMessage.Content.ReadAsStringAsync();
            //    var values = JsonConvert.DeserializeObject<List<ResultAppUserListDto>>(jsonData);
            //    return View(values);
            //}
            return View();
        }
    }
}
