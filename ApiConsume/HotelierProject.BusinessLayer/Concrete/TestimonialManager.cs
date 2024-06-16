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
	public class TestimonialManager : ITestimonialService
	{
		private readonly ITestimonialDal _testimonialDal;

		public TestimonialManager(ITestimonialDal testimonialDal)
		{
			_testimonialDal = testimonialDal;
		}

		public async Task TDelete(Testimonial t)
		{
			await _testimonialDal.Delete(t);
		}

		public async Task<Testimonial> TGetByID(int id)
		{
			return await _testimonialDal.GetByID(id);
		}

		public async Task<List<Testimonial>> TGetList()
		{
	       return await _testimonialDal.GetList();
		}

		public async Task TInsert(Testimonial t)
		{
			await _testimonialDal.Insert(t);
		}

		public async Task TUpdate(Testimonial t)
		{
			await _testimonialDal.Update(t);
		}
	}
}
