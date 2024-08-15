using TourTrack.Models;

namespace TourTrack.App.Repositories
{
    public interface IAccommodationDbRepository
    {
        void Add(Accommodation accommodation);
        void Delete(Accommodation accommodation);
        IList<Accommodation> GetAllAccommodations();
    }
}