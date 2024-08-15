using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTrack.Models;
using TourTrack.Models.Images;
using TourTrack.Models.Persistence;

namespace TourTrack.App.Repositories
{
    public class AttractionsDbRepository : IAttractionsDbRepository
    {
        private readonly TourTrackAppContext _db;
        public AttractionsDbRepository(TourTrackAppContext db)
        {
            _db = db;
        }
        public IList<Attraction> GetAllAtractions()
        {
            return _db.AttractionsDb
                .Include(x => x.Images)
                .ToList();
        }
        public void Delete(Attraction attraction)
        {
            _db.AttractionsDb.Remove(attraction);
            _db.SaveChanges();
        }
        public void Add(Attraction attraction)
        {
            _db.AttractionsDb.Add(attraction);
            _db.SaveChanges();
        }

        public void AddImage(AttractionImage img)
        {
            var existingImage = _db.Images.Find(img.Id);

            if (existingImage != null)
            {
                Console.WriteLine("Uma imagem com este ID já existe.");
                return;
            }
            _db.Images.Add(img);
            _db.SaveChanges();
        }
    }
}
