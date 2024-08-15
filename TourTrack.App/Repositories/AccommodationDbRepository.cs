using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTrack.Models;
using TourTrack.Models.Persistence;

namespace TourTrack.App.Repositories
{
    public class AccommodationDbRepository : IAccommodationDbRepository
    {
        private readonly TourTrackAppContext _db;
        public AccommodationDbRepository(TourTrackAppContext db)
        {
            _db = db;
        }
        public IList<Accommodation> GetAllAccommodations()
        {
            return _db.AccommodationsDb.ToList();
        }
        public void Delete(Accommodation accommodation)
        {
            _db.AccommodationsDb.Remove(accommodation);
            _db.SaveChanges();
        }
        public void Add(Accommodation accommodation)
        {
            _db.AccommodationsDb.Add(accommodation);
            _db.SaveChanges();
        }
    }
}
