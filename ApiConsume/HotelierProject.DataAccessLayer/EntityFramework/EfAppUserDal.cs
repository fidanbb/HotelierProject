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
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(Context context) : base(context)
        {
        }

        public async Task<int> AppUserCount()
        {
            var context=new Context();

            return await context.Users.CountAsync();
        }

        public async Task<List<AppUser>> UserListWithWorkLocations()
        {
            var context = new Context();
            return await context.Users.Include(x => x.WorkLocation).ToListAsync();
        }
    }
}
