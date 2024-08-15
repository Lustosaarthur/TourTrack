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
    public class Attraction
    {
        public required int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public required string Name { get; set; }

        [MaxLength(1000)]
        public required string Description { get; set; }

        [Range(1, 5)]
        public double Rating { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public int CountryId { get; set; }

        [MaxLength(50)]
        public required string OpeningHours { get; set; }

        [MaxLength(50)]
        public required string EntryFee { get; set; }

        public required string CountryName { get; set; }
        public ICollection<AttractionImage> Images { get; set; } = new List<AttractionImage>();
        public  ICollection<Review>? Reviews { get; set; }
    }
}
