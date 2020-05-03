using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SdpProject.Interfaces;
using SdpProject.ViewModels;

namespace SdpProject.Controllers.Dish
{
    public class NationalController : Controller
    {


        private readonly InterfaceAllDishes _allDishes;
        private readonly InterfaceCategoryDishes _allCategories;

        public NationalController(InterfaceAllDishes iAllDishes, InterfaceCategoryDishes iDishesCat)
        {
            _allDishes = iAllDishes;
            _allCategories = iDishesCat;

        }

        public IActionResult National ()
        {

            DishesListViewModel obj = new DishesListViewModel();
            obj.allDishes = _allDishes.Dishes;
            obj.currentCategory = "Menu";
            Console.WriteLine(_allDishes.Dishes);
            return View(obj);

        }
    }
}