using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.WebUI.Dtos.RoomDtos
{
    public class CreateRoomDto
    {
        [Required(ErrorMessage ="Please enter room number!")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage ="Please enter price!")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please enter title!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter bed count!")]
        public int BedCount { get; set; }
        [Required(ErrorMessage = "Please enter bath count!")]
        public int BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
