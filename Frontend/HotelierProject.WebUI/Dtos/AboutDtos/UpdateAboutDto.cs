using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.WebUI.Dtos.AboutDtos
{
    public class UpdateAboutDto
    {
        public int AboutID { get; set; }
        [Required]
        public string Title1 { get; set; }
        [Required]
        public string Title2 { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public int RoomCount { get; set; }
        [Required]
        public int StaffCount { get; set; }
        [Required]
        public int CustomerCount { get; set; }
    }
}
