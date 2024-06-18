using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.DtoLayer.SubscribeDtos
{
    public class UpdateSubscribeDto
    {
        public int SubscribeID { get; set; }
        [Required]
        public string Mail { get; set; }
    }
}
