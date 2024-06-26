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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public async Task TDelete(Contact t)
        {
            await _contactDal.Delete(t);
        }

        public async Task<Contact> TGetByID(int id)
        {
            return await _contactDal.GetByID(id);
        }

        public async Task<int> TGetCountCount()
        {
            return await _contactDal.GetCountCount();
        }

        public async Task<List<Contact>> TGetList()
        {
            return await _contactDal.GetList();
        }

        public async Task TInsert(Contact t)
        {
            await _contactDal.Insert(t);
        }

        public async Task TUpdate(Contact t)
        {

            await _contactDal.Update(t);      
        }
    }
}
