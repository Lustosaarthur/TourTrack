using Microsoft.EntityFrameworkCore;
using TourTrack.Api.Persistence;
using TourTrack.Models;

namespace TourTrack.Api.Repositories.Main
{
    public class AccommodationRepository : IAccommodationRepository
    {
        private readonly TourTrackDbContext _db;
        public AccommodationRepository(TourTrackDbContext db)
        {
            _db = db;
        }
        public IList<Accommodation> GetAccommodations()
        {
            return (IList<Accommodation>)_db.Accommodations
                .Include(x => x.Images)
                .ToList();
        }
        public IList<Accommodation> GetAccommodationByAttraction(int id)
        {
            return (IList<Accommodation>)_db.Accommodations
                .Include(x => x.Images)
                .Where(x => x.AttractionId == id)
                .ToList();
        }
        public Accommodation GetAccommodationById(int id)
        {
            return _db.Accommodations.Include(x => x.Images).ToList().SingleOrDefault(c => c.Id == id);
        }

        public IList<Accommodation> GetRandomHotels()
        {
            var listaNum = GenerateRandomNumbers();
            List<Accommodation> lista = new List<Accommodation>();
            foreach (var num in listaNum)
            {
                lista.Add(GetAccommodationById(num));
            }
            return lista;
        }
        public static List<int> GenerateRandomNumbers()
        {

            List<int> numbers = Enumerable.Range(1, 75).ToList();
            Random random = new Random();


            List<int> randomNumbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                int index = random.Next(numbers.Count);
                randomNumbers.Add(numbers[index]);
                numbers.RemoveAt(index);
            }

            return randomNumbers;
        }
    }
}
