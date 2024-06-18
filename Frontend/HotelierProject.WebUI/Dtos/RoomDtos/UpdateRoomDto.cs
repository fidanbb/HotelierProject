using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.WebUI.Dtos.RoomDtos
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Please enter room number!")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Please enter cover image!")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Please enter price!")]

        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please enter title!")]
        [StringLength(100,ErrorMessage ="Please only enter 100 character!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter bed count!")]
        public int BedCount { get; set; }
        [Required(ErrorMessage = "Please enter bath count!")]
        public int BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Please enter description!")]
        public string Description { get; set; }
    }
}
