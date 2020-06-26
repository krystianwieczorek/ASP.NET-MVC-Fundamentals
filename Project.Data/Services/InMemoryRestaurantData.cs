using Project.Data.Models;
using System;
using System.Collections.Generic;

namespace Project.Data.Services
{
    public class inMemoryRestaurantData : IRestaurantData
    {
        public IEnumerable<Restaurant> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
