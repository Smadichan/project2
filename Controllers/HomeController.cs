using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalProject2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace finalProject2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (ModelState.IsValid){
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}