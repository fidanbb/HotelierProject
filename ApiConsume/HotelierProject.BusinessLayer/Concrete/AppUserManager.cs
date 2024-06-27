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
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public async Task<int> TAppUserCount()
        {
            return await _appUserDal.AppUserCount();
        }

        public Task TDelete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AppUser>> TGetList()
        {
            return await _appUserDal.GetList();
        }

        public Task TInsert(AppUser t)
        {
            throw new NotImplementedException();
        }

        public Task TUpdate(AppUser t)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AppUser>> TUserListWithWorkLocations()
        {
          return await _appUserDal.UserListWithWorkLocations();
        }
    }
}
