using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTrack.App.AppModels;

namespace TourTrack.App.services.CategoryMenu
{
    public class CategoryMenuService
    {
        public List<CategoryMenuModels> GetCategoryMenuModels()
        {
            return MockCategoryMenuService.GetCategoryMenuModels();
        }
    }
    public class MockCategoryMenuService
    {
        public static List<CategoryMenuModels> GetCategoryMenuModels()
        {
            return new List<CategoryMenuModels>
            {
                new CategoryMenuModels
                {
                    Id = 1,
                    NameCategory = "Main Attraction",
                    Parameter = "Todas"
                },
                new CategoryMenuModels
                {
                    Id = 2,
                    NameCategory = "Popular",
                    Parameter = "Popular",
                },
                new CategoryMenuModels
                {
                    Id = 3,
                    NameCategory = "Recomended",
                    Parameter = "Recomended"
                },
            };
        }
    }
}
