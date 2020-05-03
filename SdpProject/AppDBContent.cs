using Microsoft.EntityFrameworkCore;
using SdpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SdpProject
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Dish> Dish { get; set; }
        public DbSet<Category> Category { get; set; }



    }

}
