using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTrack.Models.Images;

namespace TourTrack.Models
{
    public class Accommodation
    {
        public required int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public required string Name { get; set; }

        [MaxLength(1000)]
        public required string Description { get; set; }

        public required int AttractionId { get; set; }

        [MaxLength(50)]
        public required string PricePerNight { get; set; }

        public ICollection<AccommodationImage>? Images { get; set; } = new List<AccommodationImage>();

        [Required]
        [MaxLength(500)]
        public string? Address { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Country { get; set; }

        [Required]
        public string? Policies { get; set; }

        [Required]
        public TimeSpan CheckInTime { get; set; }

        [Required]
        public TimeSpan CheckOutTime { get; set; }

        [Required]
        public string? Amenities { get; set; }

        [Required]
        [Range(0, 5)]
        public double Rating { get; set; }
    }
}
