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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public async Task TDelete(About t)
        {
           await _aboutDal.Delete(t);
        }

        public async Task<About> TGetByID(int id)
        {
            return await _aboutDal.GetByID(id);
        }

        public async Task<List<About>> TGetList()
        {
            return await _aboutDal.GetList();
        }

        public async Task TInsert(About t)
        {
            await _aboutDal.Insert(t);
        }

        public async Task TUpdate(About t)
        {
            await _aboutDal.Update(t);
        }
    }
}
