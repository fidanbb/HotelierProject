using HotelierProject.DataAccessLayer.Abstract;
using HotelierProject.DataAccessLayer.Concrete;
using HotelierProject.DataAccessLayer.Repositories;
using HotelierProject.EntityLayer.Concrete;


namespace HotelierProject.DataAccessLayer.EntityFramework
{
	public class EfRoomDal : GenericRepository<Room>, IRoomDal
	{
		public EfRoomDal(Context context) : base(context)
		{
		}
	}
}
