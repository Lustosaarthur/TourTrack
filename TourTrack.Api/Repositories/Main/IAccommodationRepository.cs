using TourTrack.Models;

namespace TourTrack.Api.Repositories.Main
{
    public interface IAccommodationRepository
    {
        IList<Accommodation> GetAccommodationByAttraction(int id);
        Accommodation GetAccommodationById(int id);
        IList<Accommodation> GetAccommodations();
        IList<Accommodation> GetRandomHotels();
    }
}