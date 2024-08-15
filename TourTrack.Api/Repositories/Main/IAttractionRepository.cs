using TourTrack.Models;

namespace TourTrack.Api.Repositories.Main
{
    public interface IAttractionRepository
    {
        IList<Attraction> GetAttractionByCountry(int id);
        Attraction GetAttractionById(int id);
        IList<Attraction> GetAttractions();
        IList<Attraction> GetAttractionsByRating(double rating);
        IList<Attraction> GetRecomendedAttractions();
    }
}