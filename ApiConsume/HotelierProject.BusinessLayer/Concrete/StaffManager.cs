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
	public class StaffManager : IStaffService
	{
		private readonly IStaffDal _staffDal;

		public StaffManager(IStaffDal staffDal)
		{
			_staffDal = staffDal;
		}

		public async Task TDelete(Staff t)
		{
			await _staffDal.Delete(t);
		}

		public async Task<Staff> TGetByID(int id)
		{
			return await _staffDal.GetByID(id);
		}

		public async Task<List<Staff>> TGetList()
		{
		   return await _staffDal.GetList();
		}

		public async Task TInsert(Staff t)
		{
		  await _staffDal.Insert(t);	
		}

		public async Task TUpdate(Staff t)
		{
			await _staffDal.Update(t);
		}
	}
}
