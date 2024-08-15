using Microsoft.EntityFrameworkCore;
using TourTrack.Api.Persistence;
using TourTrack.Models;

namespace TourTrack.Api.Repositories.Main
{
    public class AttractionRepository : IAttractionRepository
    {
        private readonly TourTrackDbContext _db;
        public AttractionRepository(TourTrackDbContext db)
        {
            _db = db;
        }
        public IList<Attraction> GetAttractions()
        {
            return (IList<Attraction>)_db.Attractions
                .Include(x => x.Images)
                .ToList();
        }
        public IList<Attraction> GetAttractionByCountry(int id)
        {
            return (IList<Attraction>)_db.Attractions
               .Include(X => X.Images)
                .Where(x => x.CountryId == id)
                .ToList();
        }
        public Attraction GetAttractionById(int id)
        {
            return _db.Attractions
                .Include(x => x.Images)
                .SingleOrDefault(x => x.Id == id);
        }
        public IList<Attraction> GetAttractionsByRating(double rating)
        {
            return _db.Attractions
                .Include(x => x.Images)
                .Where(x => x.Rating >= rating)
                .ToList();
        }

        public IList<Attraction> GetRecomendedAttractions()
        {
            var listaNum = GenerateRandomNumbers();
            List<Attraction> lista = new List<Attraction>();
            foreach (var num in listaNum)
            {
                lista.Add(GetAttractionById(num));
            }
            return lista;
        }

        public static List<int> GenerateRandomNumbers()
        {

            List<int> numbers = Enumerable.Range(1, 25).ToList();
            Random random = new Random();


            List<int> randomNumbers = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                int index = random.Next(numbers.Count);
                randomNumbers.Add(numbers[index]);
                numbers.RemoveAt(index);
            }

            return randomNumbers;
        }
    }
}
