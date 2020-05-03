using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SdpProject.Models
{
    public class Reservation
    {
        public int id { set; get; }

        public int tableID { set; get; }

        public string date { set; get;  }

        public string time { set; get; }

        public int userID { set; get; }


    }
}
