﻿using HotelierProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.BusinessLayer.Abstract
{
    public interface IBookingService:IGenericService<Booking>
    {
        Task TBookingStatusChangeApproved(int id);
        Task<int> TGetBookingCount();
        Task<List<Booking>> TLast6Bookings();
        Task TBookingStatusChangeCancel(int id);
        Task TBookingStatusChangeWait(int id);
    }
}
