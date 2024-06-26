using System.ComponentModel.DataAnnotations;

namespace HotelierProject.WebUI.Dtos.RegisterDtos
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Name field is important")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname field is important")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Username field is important")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email field is important")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Password field is important")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password field is important")]
        [Compare("Password", ErrorMessage = "Password and COnfirm Password must be same")]
        public string ConfirmPassword { get; set; }


        public int WorkLocationID { get; set; }
    }
}

