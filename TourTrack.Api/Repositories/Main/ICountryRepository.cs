using TourTrack.Models;

namespace TourTrack.Api.Repositories.Main
{
    public interface ICountryRepository
    {
        IList<Country> GetCountries();
        Country GetCountryById(int id);
    }
}