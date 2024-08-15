using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TourTrack.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string UserName { get; set; }

        [Range(1, 5)]
        public int RatingReview { get; set; }

        [MaxLength(1000)]
        public required string Comment { get; set; }

        public int? AttractionId { get; set; }
        public int? AccommodationId { get; set; }
        
    }
}