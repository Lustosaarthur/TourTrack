using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTrack.App.AppModels;

namespace TourTrack.App.services.CategoryMenu
{
    public class CountryCategoryService
    {
        public List<CountryCategory> GetCountryModels()
        {
            return MockCategoryCountryService.GetCountryModels();
        }
    }
    public class MockCategoryCountryService
    {
        public static List<CountryCategory> GetCountryModels()
        {
            return new List<CountryCategory>
            {
                new CountryCategory
                {
                    Id = 1,
                    NameCategory = "France",
                    Parameter = "France"
                },
                new CountryCategory
                {
                    Id = 2,
                    NameCategory = "EUA",
                    Parameter = "EUA",
                },
                new CountryCategory
                {
                    Id = 3,
                    NameCategory = "Italy",
                    Parameter = "Italy"
                },
                new CountryCategory
                {
                    Id = 4,
                    NameCategory = "Japan",
                    Parameter = "Japan"
                },
                new CountryCategory
                {
                    Id = 5,
                    NameCategory = "Australia",
                    Parameter = "Australia"
                },
            };
        }
    }
}
