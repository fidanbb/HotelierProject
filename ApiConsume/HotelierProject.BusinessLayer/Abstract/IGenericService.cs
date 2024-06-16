using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.BusinessLayer.Abstract
{
	public interface IGenericService<T>where T : class
	{
		Task TInsert(T t);
		Task TDelete(T t);
		Task TUpdate(T t);
		Task<List<T>> TGetList();
		Task<T> TGetByID(int id);
	}
}
