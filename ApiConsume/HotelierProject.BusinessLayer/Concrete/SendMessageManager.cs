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
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _sendMessageDal;

        public SendMessageManager(ISendMessageDal sendMessageDal)
        {
            _sendMessageDal = sendMessageDal;
        }

        public async Task TDelete(SendMessage t)
        {
           await _sendMessageDal.Delete(t);
        }

        public async Task<SendMessage> TGetByID(int id)
        {
          return await _sendMessageDal.GetByID(id);
        }

        public async Task<List<SendMessage>> TGetList()
        {
            return await _sendMessageDal.GetList();
        }

        public async Task<int> TGetSendMessageCount()
        {
           return await _sendMessageDal.GetSendMessageCount();
        }

        public async Task TInsert(SendMessage t)
        {
            await _sendMessageDal.Insert(t);
        }

        public async Task TUpdate(SendMessage t)
        {
            await _sendMessageDal.Update(t);                
        }
    }
}
