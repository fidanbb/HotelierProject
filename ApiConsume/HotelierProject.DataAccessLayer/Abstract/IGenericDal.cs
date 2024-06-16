using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.DataAccessLayer.Abstract
{
	public interface IGenericDal<T> where T : class
	{
		Task Insert(T t);
		Task Delete(T t);
		Task Update(T t);
		Task<List<T>> GetList();
		Task<T> GetByID(int id);
	}
}
