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
	public class RoomManager : IRoomService
	{
		private readonly IRoomDal _roomDal;

		public RoomManager(IRoomDal roomDal)
		{
			_roomDal = roomDal;
		}

		public async Task TDelete(Room t)
		{
			await _roomDal.Delete(t);
		}

		public async Task<Room> TGetByID(int id)
		{
			return await _roomDal.GetByID(id);
		}

		public async Task<List<Room>> TGetList()
		{
			return await _roomDal.GetList();
		}

		public async Task TInsert(Room t)
		{
			await _roomDal.Insert(t);
		}

        public async Task<List<Room>> TTakeFirstThreeRooms()
        {
           return await _roomDal.TakeFirstThreeRooms();
        }

        public async Task TUpdate(Room t)
		{
			await _roomDal.Update(t);
		}
	}
}
