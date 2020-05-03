using SdpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SdpProject.ViewModels
{
    public class DishesListViewModel
    {
        public IEnumerable<Dish> allDishes { get; set; }

        public string currentCategory { get; set; }

    }
}
