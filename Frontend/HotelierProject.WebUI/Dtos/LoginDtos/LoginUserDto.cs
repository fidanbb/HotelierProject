using System.ComponentModel.DataAnnotations;

namespace HotelierProject.WebUI.Dtos.LoginDtos
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Please enter username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }
    }
}
