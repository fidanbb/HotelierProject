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
    public class WorkLocationManager : IWorkLocationService
    {
        private readonly IWorkLocationDal _workLocationDal;

        public WorkLocationManager(IWorkLocationDal workLocationDal)
        {
            _workLocationDal = workLocationDal;
        }

        public async Task TDelete(WorkLocation t)
        {
           await _workLocationDal.Delete(t);
        }

        public async Task<WorkLocation> TGetByID(int id)
        {
            return await _workLocationDal.GetByID(id);
        }

        public async Task<List<WorkLocation>> TGetList()
        {
            return await _workLocationDal.GetList();
        }

        public async Task TInsert(WorkLocation t)
        {
            await _workLocationDal.Insert(t);
        }

        public async Task TUpdate(WorkLocation t)
        {
            await _workLocationDal.Update(t);
        }
    }
}
