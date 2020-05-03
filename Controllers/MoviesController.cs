using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SdpProject.Models;

namespace SdpProject.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Genre,Price,ReleaseDate,Title,Rating")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(movie);
        }
    }
}