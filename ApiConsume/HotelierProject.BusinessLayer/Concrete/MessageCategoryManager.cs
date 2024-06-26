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
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategoryDal _messageCategoryDal;

        public MessageCategoryManager(IMessageCategoryDal messageCategoryDal)
        {
            _messageCategoryDal = messageCategoryDal;
        }

        public async Task TDelete(MessageCategory t)
        {
          await _messageCategoryDal.Delete(t);
        }

        public async Task<MessageCategory> TGetByID(int id)
        {
            return await _messageCategoryDal.GetByID(id);
        }

        public async Task<List<MessageCategory>> TGetList()
        {
           return await _messageCategoryDal.GetList();
        }

        public async Task TInsert(MessageCategory t)
        {
            await _messageCategoryDal.Insert(t);
        }

        public async Task TUpdate(MessageCategory t)
        {
            await _messageCategoryDal.Update(t);
        }
    }
}
