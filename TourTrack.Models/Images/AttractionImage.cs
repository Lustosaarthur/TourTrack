using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TourTrack.Models.Images
{
    public class AttractionImage
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Url { get; set; }

        [ForeignKey("AttractionId")]
        public int AttractionId { get; set; }
    }
}