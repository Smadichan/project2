using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SdpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SdpProject.Database
{
    public class DBObjects
    {

        public static void Initital(AppDBContent content)
        {

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));

            }

            if (!content.Dish.Any())
            {
                content.AddRange(
                    new Dish
                    {
                        name = "Pizza",
                        shortDesc = "E",
                        longDesc = "EEE",
                        img = "image",
                        price = 2300,
                        Category = Categories["Hot meals"]
                    },

                    new Dish
                    {
                        name = "Dorritos",
                        shortDesc = "E",
                        longDesc = "EEE",
                        img = "image",
                        price = 1200,
                        Category = Categories["Snacks"]
                    },

                    new Dish
                    {
                        name = "Black tea",
                        shortDesc = "E",
                        longDesc = "EEE",
                        img = "image",
                        price = 900,
                        Category = Categories["Drinks"]
                    },

                    new Dish
                    {
                        name = "Icecream",
                        shortDesc = "E",
                        longDesc = "EEE",
                        img = "image",
                        price = 1500,
                        Category = Categories["Desserts"]
                    }




                    );
            }

            content.SaveChanges();
        
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName ="Hot meals", desc = "Description 1" },
                        new Category { categoryName ="Snacks", desc = "Description 2" },
                        new Category { categoryName ="Drinks", desc = "Description 3" },
                        new Category { categoryName ="Desserts", desc = "Description 4" }


                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category e in list)
                    {
                        category.Add(e.categoryName, e);

                    }
                }
                return category;
            }


        }
    }
}
