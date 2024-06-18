using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.WebUI.Dtos.StaffDtos
{
    public class UpdateStaffDto
    {
        public int StaffID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string SocialMedia1 { get; set; }
        [Required]
        public string SocialMedia2 { get; set; }
        [Required]
        public string SocialMedia3 { get; set; }
    }
}
