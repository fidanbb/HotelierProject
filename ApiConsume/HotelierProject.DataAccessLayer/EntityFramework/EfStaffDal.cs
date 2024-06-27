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
	public class EfStaffDal : GenericRepository<Staff>, IStaffDal
	{
		public EfStaffDal(Context context) : base(context)
		{
		}

        public async Task<int> GetStaffCount()
        {
            using var context = new Context();

            return await context.Staffs.CountAsync();
        }

        public async Task<List<Staff>> Last4Staff()
        {
            using var context = new Context();

            return await context.Staffs.OrderByDescending(x => x.StaffID).Take(4).ToListAsync();
        }
    }
}
