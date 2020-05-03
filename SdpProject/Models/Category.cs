using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SdpProject.Models
{
    public class Category
    {
        public int id { set; get; }

        public string categoryName { set; get; }

        public string desc { set; get; }

        public List<Dish> dishes { set; get; }

    }
}
