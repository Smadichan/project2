using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SdpProject.Models
{
    public class Dish
    {
        public int id { set; get; }

        public string name { set; get; }

        public string shortDesc { set; get;  }

        public string longDesc { set; get; }

        public string img { set; get; }

        public int price { set; get; }

        public int categoryID { set; get; }

        public virtual Category Category { set; get; }


    }
}
