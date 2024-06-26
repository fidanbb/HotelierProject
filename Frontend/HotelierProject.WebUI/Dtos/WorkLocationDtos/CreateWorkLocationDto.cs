using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.WebUI.Dtos.WorkLocationDtos
{
    public class CreateWorkLocationDto
    {
        public int WorkLocationID { get; set; }
        public string WorkLocationName { get; set; }
        public string WorkLocationCity { get; set; }
    }
}
