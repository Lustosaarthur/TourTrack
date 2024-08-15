using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTrack.Models.Images;

namespace TourTrack.Models.Persistence
{
    public class TourTrackAppContext : DbContext
    {
        public DbSet<Attraction> AttractionsDb { get; set; }
        public DbSet<Accommodation> AccommodationsDb { get; set; }
        public DbSet<AttractionImage> Images { get; set; }
        public TourTrackAppContext()
        {
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "tourtrack_test_01.db");

            optionsBuilder.UseSqlite($"Filename={databasePath}");
        }
    }
}
