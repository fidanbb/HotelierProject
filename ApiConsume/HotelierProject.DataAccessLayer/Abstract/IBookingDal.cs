﻿using HotelierProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.DataAccessLayer.Abstract
{
    public interface IBookingDal:IGenericDal<Booking>
    {
        Task BookingStatusChangeApproved(int id);
        Task<int> GetBookingCount();
        Task<List<Booking>> Last6Bookings();
        Task BookingStatusChangeCancel(int id);
        Task BookingStatusChangeWait(int id);
    }
}
