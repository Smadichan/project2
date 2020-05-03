using Microsoft.EntityFrameworkCore;
using SdpProject.Interfaces;
using SdpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SdpProject.Repository
{
    public class DishRepository : InterfaceAllDishes
    {

        private readonly AppDBContent appDBContent;

        public DishRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;

        }

        public IEnumerable<Dish> Dishes => appDBContent.Dish.Include( c => c.Category);


        public Dish getObjectDish(int dishID) => appDBContent.Dish.FirstOrDefault(p => p.id == dishID);
    }
}
