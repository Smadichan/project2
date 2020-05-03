using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SdpProject.Interfaces;
using SdpProject.ViewModels;

namespace SdpProject.Controllers
{
    public class DishesController : Controller
    {
        private readonly InterfaceAllDishes _allDishes;
        private readonly InterfaceCategoryDishes _allCategories;

        public DishesController(InterfaceAllDishes iAllDishes, InterfaceCategoryDishes iDishesCat)
        {
            _allDishes = iAllDishes;
            _allCategories = iDishesCat;

        }

        public ViewResult List() 
        {
            DishesListViewModel obj = new DishesListViewModel();
            obj.allDishes = _allDishes.Dishes;
            obj.currentCategory = "Menu";
            Console.WriteLine(_allDishes.Dishes);
            return View(obj);
        }

    }
}
