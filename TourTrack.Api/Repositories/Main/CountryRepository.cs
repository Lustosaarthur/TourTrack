using Microsoft.Identity.Client;
using TourTrack.Api.Persistence;
using TourTrack.Models;

namespace TourTrack.Api.Repositories.Main
{
    public class CountryRepository : ICountryRepository
    {
        public readonly TourTrackDbContext _db;

        public CountryRepository(TourTrackDbContext db)
        {
            _db = db;
        }
        public IList<Country> GetCountries()
        {
            return _db.Countries.ToList();
        }
        public Country GetCountryById(int id)
        {
            return _db.Countries.ToList().SingleOrDefault(c => c.Id == id);
        }
    }
}
