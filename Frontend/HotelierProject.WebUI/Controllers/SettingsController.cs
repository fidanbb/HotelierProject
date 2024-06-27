using HotelierProject.EntityLayer.Concrete;
using HotelierProject.WebUI.Dtos.AppUserDto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelierProject.WebUI.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditDto model = new UserEditDto();
            model.Name = user.Name;
            model.Surname = user.Surname;
            model.Username = user.UserName;
            model.Email = user.Email;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditDto model)
        {
            if (model.Password == model.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.Name = model.Name;
                user.Surname = model.Surname;
                user.Email = model.Email;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
