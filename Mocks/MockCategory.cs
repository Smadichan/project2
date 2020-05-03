using SdpProject.Interfaces;
using SdpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SdpProject.Mocks
{
    public class MockCategory : InterfaceCategoryDishes
    {
        public IEnumerable<Category> AllCategories
        {
            get 
            {
                return new List<Category>
                {
                    new Category { categoryName ="Hot meals", desc = "Description 1" },
                    new Category { categoryName ="Snacks", desc = "Description 2" },
                    new Category { categoryName ="Drinks", desc = "Description 3" },
                    new Category { categoryName ="Desserts", desc = "Description 4" }

                };



             }
        
        }
    }
}
