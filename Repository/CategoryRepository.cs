using SdpProject.Interfaces;
using SdpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SdpProject.Repository
{
    public class CategoryRepository : InterfaceCategoryDishes
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;

        }

        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
