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
	public class SubscribeManager : ISubscribeService
	{
		private readonly ISubscribeDal _subscribeDal;

		public SubscribeManager(ISubscribeDal subscribeDal)
		{
			_subscribeDal = subscribeDal;
		}

		public async Task TDelete(Subscribe t)
		{
			await _subscribeDal.Delete(t);
		}

		public async Task<Subscribe> TGetByID(int id)
		{
			return await _subscribeDal.GetByID(id);
		}

		public async Task<List<Subscribe>> TGetList()
		{
			return await _subscribeDal.GetList();
		}

		public async Task TInsert(Subscribe t)
		{
			await _subscribeDal.Insert(t);
		}

		public async Task TUpdate(Subscribe t)
		{
			await _subscribeDal.Update(t);
		}
	}
}
