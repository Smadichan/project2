using Microsoft.EntityFrameworkCore;
using SdpProject.Interfaces;
using SdpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SdpProject.Mocks
{
    public class MockDishes : InterfaceAllDishes
    {

        private readonly InterfaceCategoryDishes _categoryDishes = new MockCategory();

        public IEnumerable<Dish> Dishes 
        {
            get
            {
                return new List<Dish>
                {
                    new Dish
                    { 
                        name = "Pizza", 
                        shortDesc = "E", 
                        longDesc = "EEE", 
                        img = "image", 
                        price = 2300, 
                        Category = _categoryDishes.AllCategories.First() 
                    }


                };

            }

        }

        public Dish getObjectDish(int dishID)
        {
            throw new NotImplementedException();
        }
    }
}
