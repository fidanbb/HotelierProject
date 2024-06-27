using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.DataAccessLayer.Concrete;
using HotelierProject.DataAccessLayer.Repositories;
using HotelierProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelierProject.DataAccessLayer.EntityFramework
{
	public class EfRoomDal : GenericRepository<Room>, IRoomDal
	{
		public EfRoomDal(Context context) : base(context)
		{
		}

        public async Task<int> RoomCount()
        {
            using var context = new Context();

            return await context.Rooms.CountAsync();
        }

        public async Task<List<Room>> TakeFirstThreeRooms()
        {
            using var context = new Context();

            return await context.Rooms.OrderBy(x=>x.RoomID).Take(3).ToListAsync();
        }
    }
}
