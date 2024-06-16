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
	public class ServiceManager : IServiceService
	{
		private readonly IServiceDal _serviceDal;

		public ServiceManager(IServiceDal serviceDal)
		{
			_serviceDal = serviceDal;
		}

		public async Task TDelete(Service t)
		{
			await _serviceDal.Delete(t);
		}

		public async Task<Service> TGetByID(int id)
		{
			return await _serviceDal.GetByID(id);
		}

		public async Task<List<Service>> TGetList()
		{
		 return	await _serviceDal.GetList();
		}

		public async Task TInsert(Service t)
		{
			await _serviceDal.Insert(t);
		}

		public async Task TUpdate(Service t)
		{
			await _serviceDal.Update(t);
		}
	}
}
