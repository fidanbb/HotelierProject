using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.DataAccessLayer.Concrete;
using HotelierProject.DataAccessLayer.Repositories;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        {
        }

        public async Task BookingStatusChangeApproved(int id)
        {
            using var context = new Context();  

            var value=await context.Bookings.FindAsync(id);

            value.Status = "Approved";
            
            await context.SaveChangesAsync();
        }

        public async Task BookingStatusChangeCancel(int id)
        {
            using var context = new Context();

            var value = await context.Bookings.FindAsync(id);

            value.Status = "Canceled";

            await context.SaveChangesAsync();
        }

        public async Task BookingStatusChangeWait(int id)
        {
            using var context = new Context();

            var value = await context.Bookings.FindAsync(id);

            value.Status = "Customer Will Be Called";

            await context.SaveChangesAsync();
        }

        public async Task<int> GetBookingCount()
        {
            using var context = new Context();

            return await context.Bookings.CountAsync();
        }

        public async Task<List<Booking>> Last6Bookings()
        {
            using var context = new Context();
            return await context.Bookings.OrderByDescending(x=>x.BookingID).Take(6).ToListAsync();
        }
    }
}
