using HotelierProject.BusinessLayer.Abstract;
using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public async Task TBookingStatusChangeApproved(int id)
        {
            await _bookingDal.BookingStatusChangeApproved(id);
        }

        public async Task TBookingStatusChangeCancel(int id)
        {
            await _bookingDal.BookingStatusChangeCancel(id);
        }

        public async Task TBookingStatusChangeWait(int id)
        {
            await _bookingDal.BookingStatusChangeWait(id);
        }

        public async Task TDelete(Booking t)
        {
            await _bookingDal.Delete(t);
        }

        public async Task<int> TGetBookingCount()
        {
          return await _bookingDal.GetBookingCount();
        }

        public async Task<Booking> TGetByID(int id)
        {
           return await _bookingDal.GetByID(id);
        }

        public async Task<List<Booking>> TGetList()
        {
            return await _bookingDal.GetList();
        }

        public async Task TInsert(Booking t)
        {
            await _bookingDal.Insert(t);
        }

        public async Task<List<Booking>> TLast6Bookings()
        {
           return await _bookingDal.Last6Bookings();
        }

        public async Task TUpdate(Booking t)
        {
            await _bookingDal.Update(t);
        }
    }
}
