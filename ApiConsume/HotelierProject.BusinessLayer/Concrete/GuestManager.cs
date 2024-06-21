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
    public class GuestManager : IGuestService
    {
        private readonly IGuestDal _guestDal;

        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public async Task TDelete(Guest t)
        {
           await _guestDal.Delete(t);
        }

        public async Task<Guest> TGetByID(int id)
        {
          return await _guestDal.GetByID(id);
        }

        public async Task<List<Guest>> TGetList()
        {
            return await _guestDal.GetList();
        }

        public async Task TInsert(Guest t)
        {
           await _guestDal.Insert(t);
        }

        public async Task TUpdate(Guest t)
        {
            await _guestDal.Update(t);
        }
    }
}
