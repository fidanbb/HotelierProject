﻿using HotelierProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierProject.DataAccessLayer.Abstract
{
	public interface IRoomDal:IGenericDal<Room>
	{
        Task<int> RoomCount();
        Task<List<Room>> TakeFirstThreeRooms();
	}
}
