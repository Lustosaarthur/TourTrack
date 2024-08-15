using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTrack.Models
{
    public class Country
    {
        public required int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }

        [Required]
        [MaxLength(3)]
        public string? Code { get; set; }

    }
}
