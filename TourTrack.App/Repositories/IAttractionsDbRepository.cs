using TourTrack.Models;
using TourTrack.Models.Images;

namespace TourTrack.App.Repositories
{
    public interface IAttractionsDbRepository
    {
        void Add(Attraction attraction);
        void AddImage(AttractionImage img);
        void Delete(Attraction attraction);
        IList<Attraction> GetAllAtractions();
    }
}