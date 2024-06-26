﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.DtoLayer.ContactDtos
{
    public class UpdateContactDto
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public int MessageCategoryID { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
