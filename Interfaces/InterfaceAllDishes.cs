using SdpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SdpProject.Interfaces
{
    public interface InterfaceAllDishes
    {
        IEnumerable<Dish> Dishes { get; }
        Dish getObjectDish(int dishID);

    }
}
