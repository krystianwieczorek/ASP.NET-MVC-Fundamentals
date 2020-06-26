using Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurant;

        public InMemoryRestaurantData()
        {
            restaurant = new List<Restaurant>()
            {
                new Restaurant{ Id = 1, Name = "Pizzaland", Cuisine = CuisineType.Italian },
                new Restaurant{ Id = 2, Name = "Pizzaland2", Cuisine = CuisineType.Italian },
                new Restaurant{ Id = 3, Name = "Pizzaland3", Cuisine = CuisineType.Italian },
                new Restaurant{ Id = 4, Name = "Pizzaland4", Cuisine = CuisineType.Italian }
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurant.OrderBy(r => r.Name);
        }
    }
}
