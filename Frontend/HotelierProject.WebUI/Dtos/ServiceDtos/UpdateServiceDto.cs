using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.WebUI.Dtos.ServiceDtos
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required]
        public string ServiceIcon { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
