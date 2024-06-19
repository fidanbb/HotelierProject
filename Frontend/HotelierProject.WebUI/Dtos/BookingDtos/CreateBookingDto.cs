using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.WebUI.Dtos.BookingDtos
{
    public class CreateBookingDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public DateTime Checkin { get; set; }
        [Required]
        public DateTime CheckOut { get; set; }
        [Required]
        public int AdultCount { get; set; }
        [Required]
        public int ChildCount { get; set; }
        [Required]
        public int RoomCount { get; set; }
        public string SpecialRequest { get; set; }
        public string Description { get; set; }
        [Required]
        public string Status { get; set; }

      
    }
}
