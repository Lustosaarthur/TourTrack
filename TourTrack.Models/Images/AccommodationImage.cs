using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TourTrack.Models.Images
{
    public class AccommodationImage
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Url { get; set; }

        [ForeignKey("AccommodationId")]
        public int AccommodationId { get; set; }
    }
}