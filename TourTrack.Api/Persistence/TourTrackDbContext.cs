using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TourTrack.Models;
using TourTrack.Models.Images;

namespace TourTrack.Api.Persistence
{
    public class TourTrackDbContext : DbContext
    {
        public TourTrackDbContext(DbContextOptions<TourTrackDbContext> options) : base(options)
        {
            
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<AttractionImage> attractionImages { get; set; }
        public DbSet<AccommodationImage> accommodationImages { get; set; }
        public DbSet<Review> Reviews { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                 new Country { Id = 1, Name = "France", Code = "Fr"},
                 new Country { Id = 2, Name = "United States", Code = "US" },
                 new Country { Id = 3, Name = "Italy", Code = "It" },
                 new Country { Id = 4, Name = "Japan", Code = "Jp" },
                 new Country { Id = 5, Name = "Australia", Code = "Au" }
            );

            modelBuilder.Entity<Attraction>().HasData(
                // France
                new Attraction {
                    Id = 1,
                    Name = "Eiffel Tower",
                    Description = "An iconic symbol of Paris, offering panoramic views of the city.",
                    Latitude = 48.8584,
                    Longitude = 2.2945,
                    CountryId = 1,
                    OpeningHours = "09:00 - 00:45",
                    EntryFee = "€25.90",
                    CountryName = "Av. Gustave Eiffel, Paris, France",
                    Rating = 5
                    
                },
                new Attraction
                {
                    Id = 2,
                    Name = "Louvre Museum",
                    Description = "The world's largest art museum and a historic monument in Paris.",
                    Latitude = 48.8606,
                    Longitude = 2.3376,
                    CountryId = 1,
                    OpeningHours = "09:00 - 18:00",
                    EntryFee = "€17",
                    CountryName = "Art Museum, Paris, France",
                    Rating = 4.5
                },
                new Attraction
                {
                    Id = 3,
                    Name = "Versailles Palace",
                    Description = "The Palace of Versailles is a former royal residence commissioned by King Louis XIV located in Versailles, about 19 kilometers west of Paris, France.",
                    Latitude = 48.8047,
                    Longitude = 2.1204,
                    CountryId = 1,
                    OpeningHours = "09:00 - 18:30",
                    EntryFee = "€18",
                    CountryName = "Place d'Armes, Versailles, France",
                    Rating = 5
                },
                new Attraction
                {
                    Id = 4,
                    Name = "Mont Saint-Michel",
                    Description = "Mont-Saint-Michel is a tidal island and mainland commune in Normandy, France. The island lies approximately one kilometre off France's north-western coast, at the mouth of the Couesnon River near Avranches and is 7 hectares in area.",
                    Latitude = 48.6367,
                    Longitude = -1.5113,
                    CountryId = 1,
                    OpeningHours = "09:30 - 18:00",
                    EntryFee = "€10",
                    CountryName = "Normandy, France",
                    Rating = 4
                },
                new Attraction
                {
                    Id = 5,
                    Name = "Château de Chambord",
                    Description = "The Château de Chambord in Chambord, Centre-Val de Loire, France, is one of the most recognisable châteaux in the world because of its very distinctive French Renaissance architecture, which blends traditional French medieval forms with classical Renaissance structures.",
                    Latitude = 47.6166,
                    Longitude = 1.5197,
                    CountryId = 1,
                    OpeningHours = "09:00 - 18:00",
                    EntryFee = "€14",
                    CountryName = "Chambord, France",
                    Rating = 4
                },
                // United States
                new Attraction
                {
                    Id = 6,
                    Name = "Grand Canyon National Park",
                    Description = "Grand Canyon National Park, in Arizona, is home to much of the immense Grand Canyon, with its layered bands of red rock revealing millions of years of geological history. Viewpoints include Mather Point, Yavapai Observation Station and architect Mary Colter’s Lookout Studio and her Desert View Watchtower. Lipan Point, with wide views of the canyon and Colorado River, is a popular, especially at sunrise and sunset.",
                    Latitude = 36.1069,
                    Longitude = -112.1129,
                    CountryId = 2,
                    OpeningHours = "24 hours",
                    EntryFee = "$35 per vehicle",
                    CountryName = "Arizona, United States",
                    Rating = 4
                },
                new Attraction
                {
                    Id = 7,
                    Name = "Statue of Liberty",
                    Description = "The Statue of Liberty is a colossal neoclassical sculpture on Liberty Island in New York Harbor, within New York City. The copper-clad statue, a gift to the United States from the people of France, was designed by French sculptor Frédéric Auguste Bartholdi and its metal framework was built by Gustave Eiffel.",
                    Latitude = 40.6892,
                    Longitude = -74.0445,
                    CountryId = 2,
                    OpeningHours = "08:30 - 16:00",
                    EntryFee = "$18.50",
                    CountryName = "New York, United States",
                    Rating = 5
                },
                new Attraction
                {
                    Id = 8,
                    Name = "Yellowstone National Park",
                    Description = "Yellowstone National Park is a nearly 3,500-sq.-mile wilderness recreation area atop a volcanic hot spot. Mostly in Wyoming, the park spreads into parts of Montana and Idaho too. Yellowstone features dramatic canyons, alpine rivers, lush forests, hot springs and gushing geysers, including its most famous, Old Faithful. It's also home to hundreds of animal species, including bears, wolves, bison, elk and antelope.",
                    Latitude = 44.428,
                    Longitude = -110.5885,
                    CountryId = 2,
                    OpeningHours = "24 hours",
                    EntryFee = "$35 per vehicle",
                    CountryName = "United States",
                    Rating = 4
                },
                new Attraction
                {
                    Id = 9,
                    Name = "Walt Disney World Resort",
                    Description = "The Walt Disney World Resort is an entertainment resort complex located about 20 miles southwest of Orlando, Florida, United States. Opened on October 1, 1971, the resort is operated by Disney Experiences, a division of The Walt Disney Company. The property covers nearly 25,000 acres, of which half has been developed.",
                    Latitude = 28.3852,
                    Longitude = -81.5639,
                    CountryId = 2,
                    OpeningHours = "Varies by park",
                    EntryFee = "$109 and up",
                    CountryName = "Florida, United States",
                    Rating = 5
                },
                new Attraction
                {
                    Id = 10,
                    Name = "Golden Gate Bridge",
                    Description = "The Golden Gate Bridge is a suspension bridge spanning the Golden Gate, the one-mile-wide strait connecting San Francisco Bay and the Pacific Ocean.",
                    Latitude = 37.8199,
                    Longitude = -122.4783,
                    CountryId = 2,
                    OpeningHours = "24 hours",
                    EntryFee = "Free",
                    CountryName = " San Francisco, Marin County",
                    Rating = 4
                },
                //Italy
                new Attraction
                {
                    Id = 11,
                    Name = "Colosseum",
                    Description = "The Colosseum is an elliptical amphitheatre in the centre of the city of Rome, Italy, just east of the Roman Forum. It is the largest ancient amphitheatre ever built, and is still the largest standing amphitheatre in the world, despite its age..",
                    Latitude = 41.8902,
                    Longitude = 12.4922,
                    CountryId = 3,
                    OpeningHours = "08:30 - 19:15",
                    EntryFee = "€16",
                    CountryName = "Piazza del Colosseo, Roma RM, Italy",
                    Rating = 5
                },
                new Attraction
                {
                    Id = 12,
                    Name = "Venice Canals",
                    Description = "Famous waterways and historic architecture in Venice.",
                    Latitude = 45.4408,
                    Longitude = 12.3155,
                    CountryId = 3,
                    OpeningHours = "24 hours",
                    EntryFee = "Free",
                    CountryName = "Venice, Italy",
                    Rating = 4
                },
                new Attraction
                {
                    Id = 13,
                    Name = "Leaning Tower of Pisa",
                    Description = "The Leaning Tower of Pisa, or simply the Tower of Pisa, is the campanile, or freestanding bell tower, of Pisa Cathedral. It is known for its nearly four-degree lean, the result of an unstable foundation.",
                    Latitude = 43.723,
                    Longitude = 10.3966,
                    CountryId = 3,
                    OpeningHours = "09:00 - 19:00",
                    EntryFee = "€18",
                    CountryName = " Piazza del Duomo, Pisa PI, Italy",
                    Rating = 4
                },
                new Attraction
                {
                    Id = 14,
                    Name = "Florence Cathedral",
                    Description = "Florence Cathedral, formally the Cathedral of Saint Mary of the Flower, is the cathedral of Florence, Italy. It was begun in 1296 in the Gothic style to a design of Arnolfo di Cambio and was structurally completed by 1436, with the dome engineered by Filippo Brunelleschi.",
                    Latitude = 43.7734,
                    Longitude = 11.2551,
                    CountryId = 3,
                    OpeningHours = "10:00 - 17:00",
                    EntryFee = "€18",
                    CountryName = "Piazza del Duomo, Firenze FI, Italy",
                    Rating = 4
                },
                new Attraction
                {
                    Id = 15,
                    Name = "Amalfi Coast",
                    Description = "The Amalfi Coast is a 50-kilometer stretch of coastline along the southern edge of Italy’s Sorrentine Peninsula, in the Campania region. It’s a popular holiday destination, with sheer cliffs and a rugged shoreline dotted with small beaches and pastel-colored fishing villages. The coastal road between the port city of Salerno and clifftop Sorrento winds past grand villas, terraced vineyards and cliffside lemon groves. ",
                    Latitude = 40.634,
                    Longitude = 14.6026,
                    CountryId = 3,
                    OpeningHours = "24 hours",
                    EntryFee = "Free",
                    CountryName = "Amalfi, Province of Salerno, Italy",
                    Rating = 3.5
                },
                //Japan
                new Attraction
                {
                    Id = 16,
                    Name = "Mount Fuji",
                    Description = "apan’s Mt. Fuji is an active volcano about 100 kilometers southwest of Tokyo. Commonly called “Fuji-san,” it’s the country’s tallest peak, at 3,776 meters. A pilgrimage site for centuries, it’s considered one of Japan’s 3 sacred mountains, and summit hikes remain a popular activity. Its iconic profile is the subject of numerous works of art, notably Edo Period prints by Hokusai and Hiroshige.",
                    Latitude = 35.3606,
                    Longitude = 138.7274,
                    CountryId = 4,
                    OpeningHours = "24 hours",
                    EntryFee = "¥1000",
                    CountryName = "Japan",
                    Rating = 3.5
                },
                new Attraction
                {
                    Id = 17,
                    Name = "Tokyo Tower",
                    Description = "The Tokyo Tower is a communications and observation tower in the Shiba-koen district of Minato, Tokyo, Japan, built in 1958. At 332.9 meters, it was the tallest tower in Japan until the construction of Tokyo Skytree in 2012.",
                    Latitude = 35.6586,
                    Longitude = 139.7454,
                    CountryId = 4,
                    OpeningHours = "09:00 - 23:00",
                    EntryFee = "¥1200",
                    CountryName = "Minato City, Tokyo, Japan",
                    Rating = 3.5
                },
                new Attraction
                {
                    Id = 18,
                    Name = "Kyoto Imperial Palace",
                    Description = "In Japan, the Sentō Imperial Palace traditionally does not refer to a single location, but to any residence of retired emperors. Before Akihito abdicated in 2019, the last Emperor to retire did so in 1817, so the designation commonly refers to the historical Kyoto Sento Imperial Palace.",
                    Latitude = 35.0254,
                    Longitude = 135.7621,
                    CountryId = 4,
                    OpeningHours = "09:00 - 17:00",
                    EntryFee = "Free",
                    CountryName = "Kyotogyoen, Kamigyo Ward, Kyoto, Japan"
                },
                new Attraction
                {
                    Id = 19,
                    Name = "Hiroshima Peace Memorial",
                    Description = "The Hiroshima Peace Memorial, originally the Hiroshima Prefectural Industrial Promotion Hall, and now commonly called the Genbaku Dome, Atomic Bomb Dome or A-Bomb Dome, is part of the Hiroshima Peace Memorial Park in Hiroshima, Japan and was designated a UNESCO World Heritage Site in 1996.",
                    Latitude = 34.3955,
                    Longitude = 132.4544,
                    CountryId = 4,
                    OpeningHours = "08:30 - 18:00",
                    EntryFee = "¥200",
                    CountryName = "Otemachi, Naka Ward, Hiroshima, Japan",
                    Rating = 4
                },
                new Attraction
                {
                    Id = 20,
                    Name = "Itsukushima Shrine",
                    Description = "Itsukushima Shrine is a Shinto shrine on the island of Itsukushima, best known for its \"floating\" torii. It is in the city of Hatsukaichi, in Hiroshima Prefecture in Japan, accessible from the mainland by ferry at Miyajimaguchi Station.",
                    Latitude = 34.2953,
                    Longitude = 132.319,
                    CountryId = 4,
                    OpeningHours = "06:30 - 18:00",
                    EntryFee = "¥300",
                    CountryName = "Miyajimacho, Hatsukaichi, Hiroshima, Japan",
                    Rating = 3.5
                },
                //Australia
                new Attraction
                {
                    Id = 21,
                    Name = "Sydeney Opera House",
                    Description = "One of the most iconic buildings in the world – the Sydney Opera House is an architectural masterpiece and vibrant performance space. It's a place where the past shapes the future, where conventions are challenged and cultures are celebrated. Step inside and discover the stories that make the Opera House so inspiring. Whether you’re a local or a tourist, a first-timer or an aficionado, the Sydney Opera House has something for everyone.",
                    Latitude = 35.3606,
                    Longitude = 138.7274,
                    CountryId = 5,
                    OpeningHours = "8:45 AM - 5:00 PM",
                    EntryFee = "₹2,520.24",
                    CountryName = "Bennelong Point, Sydney NSW 2000, Australia"
                },
                new Attraction
                {
                    Id = 22,
                    Name = "Manly Beach",
                    Description = "Manly Beach is a beach situated among the Northern Beaches of Sydney, Australia, in Manly, New South Wales. From north to south, the three main sections are Queenscliff, North Steyne, and South Steyne",
                    Latitude = 35.6586,
                    Longitude = 139.7454,
                    CountryId = 5,
                    OpeningHours = "09:00 - 23:00",
                    EntryFee = "¥1200",
                    CountryName = "Art Museum, Paris, France"
                },
                new Attraction
                {
                    Id = 23,
                    Name = "Royal Botanic Gardens Victoria - Melbourne Gardens",
                    Description = "Royal Botanic Gardens Victoria are botanic gardens across two sites–Melbourne and Cranbourne. Melbourne Gardens was founded in 1846 when land was reserved on the south side of the Yarra River for a new botanic garden. It extends across 38 hectares that slope to the river with trees, garden beds, lakes and lawns.",
                    Latitude = 35.0254,
                    Longitude = 135.7621,
                    CountryId = 5,
                    OpeningHours = "7:30 AM–5:30 PM",
                    EntryFee = "A$32.00",
                    CountryName = "Melbourne VIC 3004, Australia"
                },
                new Attraction
                {
                    Id = 24,
                    Name = "Taronga Zoo Sydney",
                    Description = "Taronga Zoo is a government-run public zoo located in Sydney, New South Wales, Australia, in the suburb of Mosman, on the shores of Sydney Harbour. The opening hours are between 9:30 a.m. to 4:30 p.m. Taronga is an Aboriginal word meaning \"beautiful view\". It was officially opened on 7 October 1916.",
                    Latitude = 34.3955,
                    Longitude = 132.4544,
                    CountryId = 5,
                    OpeningHours = "09:30",
                    EntryFee = "$105.60",
                    CountryName = "Bradleys Head Rd, Mosman NSW 2088, Australia"
                },
                new Attraction
                {
                    Id = 25,
                    Name = "South Bank Parklands",
                    Description = "Playground swings available · Has skateboarding area\r\nThe South Bank Parklands are located at South Bank within the suburb of South Brisbane in Brisbane, Queensland, Australia. The parkland, on the transformed site of Brisbane's World Expo 88, was officially opened to the public on 20 June 1992",
                    Latitude = 34.2953,
                    Longitude = 132.319,
                    CountryId = 5,
                    OpeningHours = "05:30AM - 12:00AM",
                    EntryFee = "Free",
                    CountryName = "Australia"
                }
            );
            modelBuilder.Entity<Accommodation>().HasData(
                new Accommodation
                {
                    Id = 1,
                    Name = "Paris Hotel",
                    AttractionId = 1,
                    Description = "A hotel with a view of the Eiffel Tower",
                    PricePerNight = "€230,00",
                    Address = "Address of Paris Hotel",
                    Country = "France",
                    Policies = "Free cancellation up to 24 hours before check-in.",
                    CheckInTime = new TimeSpan(15, 0, 0),
                    CheckOutTime = new TimeSpan(11, 0, 0),
                    Amenities = "Wi-Fi, Parking, Pool, Gym, Spa",
                    Rating = 4.5
                },
            new Accommodation
            {
                Id = 2,
                Name = "Eiffel View Hotel",
                AttractionId = 1,
                Description = "Luxury hotel with Eiffel Tower view",
                PricePerNight = "€350,00",
                Address = "Address of Eiffel View Hotel",
                Country = "France",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant",
                Rating = 5.0
            },
            new Accommodation
            {
                Id = 3,
                Name = "Tower Stay",
                AttractionId = 1,
                Description = "Comfortable stay near Eiffel Tower",
                PricePerNight = "€150,00",
                Address = "Address of Tower Stay",
                Country = "France",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym",
                Rating = 3.8
            },
            new Accommodation
            {
                Id = 4,
                Name = "Louvre Inn",
                AttractionId = 2,
                Description = "Boutique hotel near the Louvre",
                PricePerNight = "€200,00",
                Address = "Address of Louvre Inn",
                Country = "France",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa",
                Rating = 4.0
            },
            new Accommodation
            {
                Id = 5,
                Name = "Art Museum Hotel",
                AttractionId = 2,
                Description = "Stylish hotel close to the Louvre",
                PricePerNight = "€270,00",
                Address = "Address of Art Museum Hotel",
                Country = "France",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant",
                Rating = 4.5
            },
            new Accommodation
            {
                Id = 6,
                Name = "Louvre Luxury Suites",
                AttractionId = 2,
                Description = "Luxury suites with museum views",
                PricePerNight = "€320,00",
                Address = "Address of Louvre Luxury Suites",
                Country = "France",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant, Bar",
                Rating = 4.8
            },
            new Accommodation
            {
                Id = 7,
                Name = "Versailles Grand Hotel",
                AttractionId = 3,
                Description = "Elegant hotel near Versailles Palace",
                PricePerNight = "€300,00",
                Address = "Address of Versailles Grand Hotel",
                Country = "France",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa",
                Rating = 4.7
            },
            new     Accommodation
            {
                Id = 8,
                Name = "Royal Stay Versailles",
                AttractionId = 3,
                Description = "Royal experience near the palace",
                PricePerNight = "€400,00",
                Address = "Address of Royal Stay Versailles",
                Country = "France",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant, Bar",
                Rating = 4.9
            },
            new Accommodation
            {
                Id = 9,
                Name = "Palace View Inn",
                AttractionId = 3,
                Description = "Comfortable stay near Versailles",
                PricePerNight = "€250,00",
                Address = "Address of Palace View Inn",
                Country = "France",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym",
                Rating = 4.2
            },
            new     Accommodation
            {
                Id = 10,
                Name = "Mont Saint-Michel Hotel",
                AttractionId = 4,
                Description = "Cozy hotel on Mont Saint-Michel",
                PricePerNight = "€180,00",
                Address = "Address of Mont Saint-Michel Hotel",
                Country = "France",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa",
                Rating = 4.3
            },
            new Accommodation
            {
                Id = 11,
                Name = "Island Retreat",
                AttractionId = 4,
                Description = "Charming retreat on the island",
                PricePerNight = "€220,00",
                Address = "Address of Island Retreat",
                Country = "France",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant",
                Rating = 4.6
            },
            new Accommodation
            {
                Id = 12,
                Name = "Saint-Michel Stay",
                AttractionId = 4,
                Description = "Historic stay on Mont Saint-Michel",
                PricePerNight = "€200,00",
                Address = "Address of Saint-Michel Stay",
                Country = "France",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym",
                Rating = 4.4
            },
            new Accommodation
            {
                Id = 13,
                Name = "Chambord Castle Hotel",
                AttractionId = 5,
                Description = "Stay in a castle near Chambord",
                PricePerNight = "€280,00",
                Address = "Address of Chambord Castle Hotel",
                Country = "France",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa",
                Rating = 4.8
            },
            new Accommodation
            {
                Id = 14,
                Name = "Renaissance Inn",
                AttractionId = 5,
                Description = "Historic inn near Château de Chambord",
                PricePerNight = "€240,00",
                Address = "Address of Renaissance Inn",
                Country = "France",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant",
                Rating = 4.5
            },
            new Accommodation
            {
                Id = 15,
                Name = "Castle View Lodge",
                AttractionId = 5,
                Description = "Lodge with views of the castle",
                PricePerNight = "€260,00",
                Address = "Address of Castle View Lodge",
                Country = "France",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant, Bar",
                Rating = 4.7
            },
            new Accommodation
            {
                Id = 16,
                Name = "Great Wall Hotel",
                AttractionId = 6,
                Description = "Hotel with views of the Great Wall",
                PricePerNight = "¥1500.00",
                Address = "Address of Great Wall Hotel",
                Country = "China",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(12, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa",
                Rating = 4.6
            },
            new Accommodation
            {
                Id = 17,
                Name = "Wallside Retreat",
                AttractionId = 6,
                Description = "Retreat with Great Wall views",
                PricePerNight = "¥1800.00",
                Address = "Address of Wallside Retreat",
                Country = "China",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(12, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant",
                Rating = 4.9
            },
            new Accommodation
            {
                Id = 18,
                Name = "Historic Wall Hotel",
                AttractionId = 6,
                Description = "Historic hotel near the Great Wall",
                PricePerNight = "¥1300.00",
                Address = "Address of Historic Wall Hotel",
                Country = "China",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(12, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym",
                Rating = 4.3
            },
            new Accommodation
            {
                Id = 19,
                Name = "Forbidden City Hotel",
                AttractionId = 7,
                Description = "Luxurious stay near Forbidden City",
                PricePerNight = "¥2000.00",
                Address = "Address of Forbidden City Hotel",
                Country = "China",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(12, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa",
                Rating = 5.0
            },
            new Accommodation
            {
                Id = 20,
                Name = "Imperial Palace Inn",
                AttractionId = 7,
                Description = "Comfortable inn near Forbidden City",
                PricePerNight = "¥1700.00",
                Address = "Address of Imperial Palace Inn",
                Country = "China",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(12, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant",
                Rating = 4.8
            },
            new Accommodation
            {
                Id = 21,
                Name = "Palace View Hotel",
                AttractionId = 7,
                Description = "Hotel with Forbidden City views",
                PricePerNight = "¥1500.00",
                Address = "Address of Palace View Hotel",
                Country = "China",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(12, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant, Bar",
                Rating = 4.7
            },
            new Accommodation
            {
                Id = 22,
                Name = "Terracotta Warriors Hotel",
                AttractionId = 8,
                Description = "Stay near the Terracotta Warriors",
                PricePerNight = "¥1600.00",
                Address = "Address of Terracotta Warriors Hotel",
                Country = "China",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(12, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa",
                Rating = 4.5
            },
            new Accommodation
            {
                Id = 23,
                Name = "Warriors' Retreat",
                AttractionId = 8,
                Description = "Retreat near Terracotta Warriors",
                PricePerNight = "¥1900.00",
                Address = "Address of Warriors' Retreat",
                Country = "China",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(12, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant",
                Rating = 4.8
            },
            new Accommodation
            {
                Id = 24,
                Name = "Historic Warriors Hotel",
                AttractionId = 8,
                Description = "Historic hotel near Terracotta Warriors",
                PricePerNight = "¥1400.00",
                Address = "Address of Historic Warriors Hotel",
                Country = "China",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(12, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym",
                Rating = 4.4
            },
            new Accommodation
            {
                Id = 25,
                Name = "Stonehenge Lodge",
                AttractionId = 9,
                Description = "Lodge near Stonehenge",
                PricePerNight = "£150.00",
                Address = "Address of Stonehenge Lodge",
                Country = "United Kingdom",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa",
                Rating = 4.3
            },
            new Accommodation
            {
                Id = 26,
                Name = "Henge Retreat",
                AttractionId = 9,
                Description = "Retreat with Stonehenge views",
                PricePerNight = "£180.00",
                Address = "Address of Henge Retreat",
                Country = "United Kingdom",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant",
                Rating = 4.6
            },
            new Accommodation
            {
                Id = 27,
                Name = "Historic Henge Hotel",
                AttractionId = 9,
                Description = "Historic hotel near Stonehenge",
                PricePerNight = "£140.00",
                Address = "Address of Historic Henge Hotel",
                Country = "United Kingdom",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym",
                Rating = 4.2
            },
            new Accommodation
            {
                Id = 28,
                Name = "Edinburgh Castle Hotel",
                AttractionId = 10,
                Description = "Stay near Edinburgh Castle",
                PricePerNight = "£200.00",
                Address = "Address of Edinburgh Castle Hotel",
                Country = "United Kingdom",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa",
                Rating = 4.8
            },
            new Accommodation
            {
                Id = 29,
                Name = "Castle View Inn",
                AttractionId = 10,
                Description = "Inn with views of Edinburgh Castle",
                PricePerNight = "£170.00",
                Address = "Address of Castle View Inn",
                Country = "United Kingdom",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant",
                Rating = 4.5
            },
            new Accommodation
            {
                Id = 30,
                Name = "Historic Castle Stay",
                AttractionId = 10,
                Description = "Historic stay near Edinburgh Castle",
                PricePerNight = "£160.00",
                Address = "Address of Historic Castle Stay",
                Country = "United Kingdom",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym",
                Rating = 4.4
            },
            new Accommodation
            {
                Id = 31,
                Name = "Westminster Abbey Hotel",
                AttractionId = 11,
                Description = "Luxury hotel near Westminster Abbey",
                PricePerNight = "£220.00",
                Address = "Address of Westminster Abbey Hotel",
                Country = "United Kingdom",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa",
                Rating = 4.7
            },
            new Accommodation
            {
                Id = 32,
                Name = "Abbey View Inn",
                AttractionId = 11,
                Description = "Inn with views of Westminster Abbey",
                PricePerNight = "£190.00",
                Address = "Address of Abbey View Inn",
                Country = "United Kingdom",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant",
                Rating = 4.6
            },
            new Accommodation
            {
                Id = 33,
                Name = "Historic Abbey Hotel",
                AttractionId = 11,
                Description = "Historic hotel near Westminster Abbey",
                PricePerNight = "£180.00",
                Address = "Address of Historic Abbey Hotel",
                Country = "United Kingdom",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym",
                Rating = 4.4
            },
            new Accommodation
            {
                Id = 34,
                Name = "Vatican View Hotel",
                AttractionId = 12,
                Description = "Stay near the Vatican",
                PricePerNight = "€250.00",
                Address = "Address of Vatican View Hotel",
                Country = "Italy",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa",
                Rating = 4.9
            },
            new Accommodation
            {
                Id = 35,
                Name = "St. Peter's Inn",
                AttractionId = 12,
                Description = "Inn with views of St. Peter's Basilica",
                PricePerNight = "€220.00",
                Address = "Address of St. Peter's Inn",
                Country = "Italy",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant",
                Rating = 4.7
            },
            new Accommodation
            {
                Id = 36,
                Name = "Historic Vatican Hotel",
                AttractionId = 12,
                Description = "Historic hotel near the Vatican",
                PricePerNight = "€200.00",
                Address = "Address of Historic Vatican Hotel",
                Country = "Italy",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym",
                Rating = 4.5
            },
            new Accommodation
            {
                Id = 37,
                Name = "Colosseum Stay",
                AttractionId = 13,
                Description = "Hotel near the Colosseum",
                PricePerNight = "€230.00",
                Address = "Address of Colosseum Stay",
                Country = "Italy",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa",
                Rating = 4.7
            },
            new Accommodation
            {
                Id = 38,
                Name = "Gladiator's Retreat",
                AttractionId = 13,
                Description = "Stay with views of the Colosseum",
                PricePerNight = "€250.00",
                Address = "Address of Gladiator's Retreat",
                Country = "Italy",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant",
                Rating = 4.8
            },
            new Accommodation
            {
                Id = 39,
                Name = "Historic Colosseum Hotel",
                AttractionId = 13,
                Description = "Historic stay near the Colosseum",
                PricePerNight = "€200.00",
                Address = "Address of Historic Colosseum Hotel",
                Country = "Italy",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym",
                Rating = 4.5
            },
            new Accommodation
            {
                Id = 40,
                Name = "Leaning Tower Lodge",
                AttractionId = 14,
                Description = "Lodge near the Leaning Tower of Pisa",
                PricePerNight = "€190.00",
                Address = "Address of Leaning Tower Lodge",
                Country = "Italy",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa",
                Rating = 4.4
            },
            new Accommodation   
            {
                Id = 41,
                Name = "Tower View Inn",
                AttractionId = 14,
                Description = "Inn with views of the Leaning Tower",
                PricePerNight = "€210.00",
                Address = "Address of Tower View Inn",
                Country = "Italy",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant",
                Rating = 4.6
            },
            new Accommodation
            {
                Id = 42,
                Name = "Historic Tower Hotel",
                AttractionId = 14,
                Description = "Historic stay near the Leaning Tower",
                PricePerNight = "€180.00",
                Address = "Address of Historic Tower Hotel",
                Country = "Italy",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym",
                Rating = 4.3
            },
            new Accommodation
            {
                Id = 43,
                Name = "Venetian Canal Hotel",
                AttractionId = 15,
                Description = "Stay near the Grand Canal in Venice",
                PricePerNight = "€300.00",
                Address = "Address of Venetian Canal Hotel",
                Country = "Italy",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa",
                Rating = 4.9
            },
            new Accommodation
            {
                Id = 44,
                Name = "Grand Canal View Inn",
                AttractionId = 15,
                Description = "Inn with views of the Grand Canal",
                PricePerNight = "€280.00",
                Address = "Address of Grand Canal View Inn",
                Country = "Italy",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym, Spa, Restaurant",
                Rating = 4.8
            },
            new Accommodation
            {
                Id = 45,
                Name = "Historic Canal Hotel",
                AttractionId = 15,
                Description = "Historic stay near the Grand Canal",
                PricePerNight = "€260.00",
                Address = "Address of Historic Canal Hotel",
                Country = "Italy",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(14, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Pool, Gym",
                Rating = 4.7
            },
            new Accommodation
            {
                Id = 46,
                Name = "Fuji Mountain Hotel",
                AttractionId = 16,
                Description = "Hotel with views of Mount Fuji",
                PricePerNight = "¥12000",
                Address = "Address of Fuji Mountain Hotel",
                Country = "Japan",
                Policies = "Free cancellation up to 24 hours before check-in.",
                CheckInTime = new TimeSpan(15, 0, 0),
                CheckOutTime = new TimeSpan(11, 0, 0),
                Amenities = "Wi-Fi, Parking, Spa",
                Rating = 4.5
            },
        new Accommodation
        {
            Id = 47,
            Name = "Volcano View Inn",
            AttractionId = 16,
            Description = "Inn close to Mount Fuji",
            PricePerNight = "¥10000",
            Address = "Address of Volcano View Inn",
            Country = "Japan",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Restaurant",
            Rating = 4.3
        },
        new Accommodation
        {
            Id = 48,
            Name = "Fuji Stay",
            AttractionId = 16,
            Description = "Comfortable stay near the mountain",
            PricePerNight = "¥8000",
            Address = "Address of Fuji Stay",
            Country = "Japan",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking",
            Rating = 4.2
        },

        // Hotéis 49 a 51 (Tokyo Tower)
        new Accommodation
        {
            Id = 49,
            Name = "Tokyo Tower Hotel",
            AttractionId = 17,
            Description = "Hotel with views of Tokyo Tower",
            PricePerNight = "¥14000",
            Address = "Address of Tokyo Tower Hotel",
            Country = "Japan",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Spa",
            Rating = 4.6
        },
        new Accommodation
        {
            Id = 50,
            Name = "Tower View Inn",
            AttractionId = 17,
            Description = "Inn close to Tokyo Tower",
            PricePerNight = "¥12000",
            Address = "Address of Tower View Inn",
            Country = "Japan",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Restaurant",
            Rating = 4.4
        },
        new Accommodation
        {
            Id = 51,
            Name = "Tokyo Stay",
            AttractionId = 17,
            Description = "Comfortable stay near the tower",
            PricePerNight = "¥10000",
            Address = "Address of Tokyo Stay",
            Country = "Japan",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking",
            Rating = 4.1
        },

        // Hotéis 52 a 54 (Kyoto Imperial Palace)
        new Accommodation
        {
            Id = 52,
            Name = "Imperial Palace Hotel",
            AttractionId = 18,
            Description = "Hotel with views of Kyoto Imperial Palace",
            PricePerNight = "¥10000",
            Address = "Address of Imperial Palace Hotel",
            Country = "Japan",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Spa",
            Rating = 4.5
        },
        new Accommodation
        {
            Id = 53,
            Name = "Palace View Inn",
            AttractionId = 18,
            Description = "Inn close to the Imperial Palace",
            PricePerNight = "¥8000",
            Address = "Address of Palace View Inn",
            Country = "Japan",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Restaurant",
            Rating = 4.3
        },
        new Accommodation
        {
            Id = 54,
            Name = "Kyoto Stay",
            AttractionId = 18,
            Description = "Comfortable stay near the palace",
            PricePerNight = "¥6000",
            Address = "Address of Kyoto Stay",
            Country = "Japan",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking",
            Rating = 4.0
        },

        // Hotéis 55 a 57 (Hiroshima Peace Memorial)
        new Accommodation
        {
            Id = 55,
            Name = "Hiroshima Memorial Hotel",
            AttractionId = 19,
            Description = "Hotel close to Hiroshima Peace Memorial",
            PricePerNight = "¥8000",
            Address = "Address of Hiroshima Memorial Hotel",
            Country = "Japan",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Spa",
            Rating = 4.4
        },
        new Accommodation
        {
            Id = 56,
            Name = "Peace Park Inn",
            AttractionId = 19,
            Description = "Inn near Hiroshima Peace Memorial",
            PricePerNight = "¥7000",
            Address = "Address of Peace Park Inn",
            Country = "Japan",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Restaurant",
            Rating = 4.2
        },
        new Accommodation
        {
            Id = 57,
            Name = "Memorial Stay",
            AttractionId = 19,
            Description = "Comfortable stay near the memorial",
            PricePerNight = "¥6000",
            Address = "Address of Memorial Stay",
            Country = "Japan",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking",
            Rating = 4.1
        },

        // Hotéis 58 a 60 (Itsukushima Shrine)
        new Accommodation
        {
            Id = 58,
            Name = "Itsukushima Shrine Hotel",
            AttractionId = 20,
            Description = "Hotel with views of Itsukushima Shrine",
            PricePerNight = "¥9000",
            Address = "Address of Itsukushima Shrine Hotel",
            Country = "Japan",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Spa",
            Rating = 4.5
        },
        new Accommodation
        {
            Id = 59,
            Name = "Floating Torii Inn",
            AttractionId = 20,
            Description = "Inn close to the shrine",
            PricePerNight = "¥8000",
            Address = "Address of Floating Torii Inn",
            Country = "Japan",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Restaurant",
            Rating = 4.3
        },
        new Accommodation
        {
            Id = 60,
            Name = "Shrine Stay",
            AttractionId = 20,
            Description = "Comfortable stay near the shrine",
            PricePerNight = "¥7000",
            Address = "Address of Shrine Stay",
            Country = "Japan",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking",
            Rating = 4.2
        },

        // Hotéis 61 a 63 (Sydney Opera House)
        new Accommodation
        {
            Id = 61,
            Name = "Opera House Hotel",
            AttractionId = 21,
            Description = "Hotel with views of Sydney Opera House",
            PricePerNight = "AUD 250.00",
            Address = "Address of Opera House Hotel",
            Country = "Australia",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Spa",
            Rating = 4.7
        },
        new Accommodation
        {
            Id = 62,
            Name = "Harbour View Inn",
            AttractionId = 21,
            Description = "Inn close to Sydney Harbour",
            PricePerNight = "AUD 200.00",
            Address = "Address of Harbour View Inn",
            Country = "Australia",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Restaurant",
            Rating = 4.4
        },
        new Accommodation
        {
            Id = 63,
            Name = "Opera Stay",
            AttractionId = 21,
            Description = "Comfortable stay near the Opera House",
            PricePerNight = "AUD 180.00",
            Address = "Address of Opera Stay",
            Country = "Australia",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking",
            Rating = 4.1
        },

        // Hotéis 64 a 66 (Great Barrier Reef)
        new Accommodation
        {
            Id = 64,
            Name = "Reef View Hotel",
            AttractionId = 22,
            Description = "Hotel with views of the Great Barrier Reef",
            PricePerNight = "AUD 300.00",
            Address = "Address of Reef View Hotel",
            Country = "Australia",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Spa",
            Rating = 4.8
        },
        new Accommodation
        {
            Id = 65,
            Name = "Coral Inn",
            AttractionId = 22,
            Description = "Inn close to the reef",
            PricePerNight = "AUD 250.00",
            Address = "Address of Coral Inn",
            Country = "Australia",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Restaurant",
            Rating = 4.6
        },
        new Accommodation
        {
            Id = 66,
            Name = "Reef Stay",
            AttractionId = 22,
            Description = "Comfortable stay near the reef",
            PricePerNight = "AUD 200.00",
            Address = "Address of Reef Stay",
            Country = "Australia",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking",
            Rating = 4.3
        },

        // Hotéis 67 a 69 (Uluru)
        new Accommodation
        {
            Id = 67,
            Name = "Uluru View Hotel",
            AttractionId = 23,
            Description = "Hotel with views of Uluru",
            PricePerNight = "AUD 280.00",
            Address = "Address of Uluru View Hotel",
            Country = "Australia",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Spa",
            Rating = 4.5
        },
        new Accommodation
        {
            Id = 68,
            Name = "Rock Inn",
            AttractionId = 23,
            Description = "Inn close to Uluru",
            PricePerNight = "AUD 240.00",
            Address = "Address of Rock Inn",
            Country = "Australia",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Restaurant",
            Rating = 4.2
        },
        new Accommodation
        {
            Id = 69,
            Name = "Uluru Stay",
            AttractionId = 23,
            Description = "Comfortable stay near Uluru",
            PricePerNight = "AUD 200.00",
            Address = "Address of Uluru Stay",
            Country = "Australia",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking",
            Rating = 4.1
        },

        // Hotéis 70 a 72 (Bondi Beach)
        new Accommodation
        {
            Id = 70,
            Name = "Bondi Beach Hotel",
            AttractionId = 24,
            Description = "Hotel with views of Bondi Beach",
            PricePerNight = "AUD 260.00",
            Address = "Address of Bondi Beach Hotel",
            Country = "Australia",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Spa",
            Rating = 4.7
        },
        new Accommodation
        {
            Id = 71,
            Name = "Beachfront Inn",
            AttractionId = 24,
            Description = "Inn close to Bondi Beach",
            PricePerNight = "AUD 220.00",
            Address = "Address of Beachfront Inn",
            Country = "Australia",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Restaurant",
            Rating = 4.4
        },
        new Accommodation
        {
            Id = 72,
            Name = "Bondi Stay",
            AttractionId = 24,
            Description = "Comfortable stay near the beach",
            PricePerNight = "AUD 180.00",
            Address = "Address of Bondi Stay",
            Country = "Australia",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking",
            Rating = 4.1
        },

        // Hotéis 73 a 75 (Great Ocean Road)
        new Accommodation
        {
            Id = 73,
            Name = "Ocean Road Hotel",
            AttractionId = 25,
            Description = "Hotel with views of the Great Ocean Road",
            PricePerNight = "AUD 280.00",
            Address = "Address of Ocean Road Hotel",
            Country = "Australia",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Spa",
            Rating = 4.6
        },
        new Accommodation
        {
            Id = 74,
            Name = "Coastal Inn",
            AttractionId = 25,
            Description = "Inn close to the Great Ocean Road",
            PricePerNight = "AUD 240.00",
            Address = "Address of Coastal Inn",
            Country = "Australia",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking, Restaurant",
            Rating = 4.3
        },
        new Accommodation
        {
            Id = 75,
            Name = "Ocean Stay",
            AttractionId = 25,
            Description = "Comfortable stay near the ocean",
            PricePerNight = "AUD 200.00",
            Address = "Address of Ocean Stay",
            Country = "Australia",
            Policies = "Free cancellation up to 24 hours before check-in.",
            CheckInTime = new TimeSpan(15, 0, 0),
            CheckOutTime = new TimeSpan(11, 0, 0),
            Amenities = "Wi-Fi, Parking",
            Rating = 4.0
        }
                );
                


            modelBuilder.Entity<AttractionImage>().HasData(
                // ID - 1
                new AttractionImage
                {
                    Id = 1,
                    Url = "https://www.google.com/imgres?q=torre%20eiffel&imgurl=https%3A%2F%2Fimgmd.net%2Fimages%2Fv1%2Fguia%2F1704562%2Ftorre-eiffel.jpg&imgrefurl=https%3A%2F%2Fguia.melhoresdestinos.com.br%2Ftorre-eiffel-paris.html&docid=gIzbt_dOewPWdM&tbnid=u_MFMaN5pvm6QM&vet=12ahUKEwjtjILejuOHAxU4q5UCHbe-FwMQM3oECCIQAA..i&w=2400&h=1600&hcb=2&ved=2ahUKEwjtjILejuOHAxU4q5UCHbe-FwMQM3oECCIQAA",
                    AttractionId = 1,
                },
                new AttractionImage
                {
                    Id = 2,
                    Url = "https://www.voupranos.com.br/wp-content/uploads/2022/09/AdobeStock_44313077-1024x683.jpeg",
                    AttractionId = 1,
                },
                // ID - 2
                new AttractionImage
                {
                    Id = 3,
                    Url = "https://res.cloudinary.com/du5jifpgg/image/upload/t_opengraph_image/Surcharge-APIDAE/Musee_du_Louvre_ete-2023.jpg",
                    AttractionId = 2,
                },
                new AttractionImage
                {
                    Id = 4,
                    Url = "https://www.google.com/imgres?q=louvre%20museum&imgurl=https%3A%2F%2Fcdn.sortiraparis.com%2Fimages%2F80%2F103941%2F973572-visuels-musee-du-louvre.jpg&imgrefurl=https%3A%2F%2Fwww.sortiraparis.com%2Fen%2Fwhat-to-visit-in-paris%2Fexhibit-museum%2Farticles%2F1188-musee-du-louvre-discover-the-artistic-and-tourist-heart-of-the-capital&docid=kXqla4BgkWIkEM&tbnid=yPFl7K1aNrY38M&vet=12ahUKEwjj0s3ij-OHAxUcq5UCHZ9uKNUQM3oECFgQAA..i&w=1600&h=1200&hcb=2&ved=2ahUKEwjj0s3ij-OHAxUcq5UCHZ9uKNUQM3oECFgQAA",
                    AttractionId = 2,
                },
                //ID - 3
                new AttractionImage
                {
                    Id = 5,
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSc1Ni2tOFudZKoGf_Ax-tPf4qOk8nlE0IOGQ&s",
                    AttractionId = 3,
                },
                new AttractionImage
                {
                    Id = 6,
                    Url = "https://images.a12.com/source/files/c/285234/Palacio_de_Versalhes_-_Franca-933495_1000-669-0-0.jpg",
                    AttractionId = 3,
                },
                //ID - 4
                new AttractionImage
                {
                    Id = 7,
                    Url = "https://en.normandie-tourisme.fr/wp-content/uploads/sites/3/2023/07/baie-mont-saint-michel-de-nuit-marc-lerouge-1200x800.jpg",
                    AttractionId = 4,
                },
                new AttractionImage
                {
                    Id = 8,
                    Url = "https://en.normandie-tourisme.fr/wp-content/uploads/sites/3/2020/01/8118-Mont-Saint-Michel-couleur-dautomne-%C2%A9-DaLiu-Shutterstock.com-%C2%A9-DaLiu-Shutterstock.com_.jpg",
                    AttractionId = 4,
                },
                //ID - 5
                new AttractionImage
                {
                    Id = 9,
                    Url = "https://cdn.britannica.com/27/250127-050-A95F35DE/Chateaude-Chambord.jpg",
                    AttractionId = 5,
                },
                new AttractionImage
                {
                    Id = 10,
                    Url = "https://www.historyhit.com/app/uploads/2020/11/Chateau-de-Chambord.jpg",
                    AttractionId = 5,
                },
                //ID - 6
                new AttractionImage
                {
                    Id = 11,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipNyb9QfYZ6QqZflHC2eoCqyhjNKOmRrvlCHeCmq=s680-w680-h510",
                    AttractionId = 6,
                },
                new AttractionImage
                {
                    Id = 12,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipP4VxoUVCQIUUqSqKAB2qX_nWaRZgy1WkjxgM5s=s680-w680-h510",
                    AttractionId = 6,
                },
                //ID - 7
                new AttractionImage
                {
                    Id = 13,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipNOkjsKcMBL_Fia95bCQvwISPZBNG_Addfw3AYm=s680-w680-h510",
                    AttractionId = 7,
                },
                new AttractionImage
                {
                    Id = 14,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipNw_9BgocIVd5ukJqRx86w7KG_6BxMsJfNncvTm=s680-w680-h510",
                    AttractionId = 7,
                },
                //ID - 8
                new AttractionImage
                {
                    Id = 15,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipNSLBiQHaYCKNDCLcdbWxth_4uJMggdvT8bXwLt=s680-w680-h510",
                    AttractionId = 8,
                },
                new AttractionImage
                {
                    Id = 16,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipN4fq7cy0SSffufDFsZgurz0BvF2RLMc4QvnmRk=s680-w680-h510",
                    AttractionId = 8,
                },
                //ID - 9
                new AttractionImage
                {
                    Id = 17,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipMfwcz2feEkN1CXLkhQxnwU3kUYO8rL1R4PBPX2=s680-w680-h510",
                    AttractionId = 9,
                },
                new AttractionImage
                {
                    Id = 18,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipMkdB67tOCrTPHUzDH4UuBx6pcf6Wna5Y0htqDt=s680-w680-h510",
                    AttractionId = 9,
                },
                //ID - 10
                new AttractionImage
                {
                    Id = 19,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipN0-mJ4M1ftzod1vtrdwMyE2fmmqxGdPxnvQMH4=s680-w680-h510",
                    AttractionId = 10,
                },
                new AttractionImage
                {
                    Id = 20,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipNUPAS5i4G9UsOnKyz8oUAZIhYUlaUrre3fjzqR=s680-w680-h510",
                    AttractionId = 10,
                },
                // ID - 11
                new AttractionImage
                {
                    Id = 21,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipO0jDqEA4d2y-H9bcfOJ3NgTPhpbdFNFdwB3eZu=s680-w680-h510",
                    AttractionId = 11,
                },
                new AttractionImage
                {
                    Id = 22,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipM1Pzbc3Wy6NPD7hqH0ILX5MpsrfAB-6S9koOR2=s680-w680-h510",
                    AttractionId = 11,
                },
                // ID - 12
                new AttractionImage
                {
                    Id = 23,
                    Url = "https://as1.ftcdn.net/v2/jpg/02/99/91/98/1000_F_299919821_Ege4s2w90kGGCi4fAsVg4zYW1BMkxqh2.jpg",
                    AttractionId = 12,
                },
                new AttractionImage
                {
                    Id = 24,
                    Url = "https://www.exp1.com/blog/wp-content/uploads/sites/7/2018/03/venice1.jpeg",
                    AttractionId = 12,
                },
                //ID - 13
                new AttractionImage
                {
                    Id = 25,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipNCVdTcDJAScCRhWktcizQUxYrlj59Ywhv44uKw=s680-w680-h510",
                    AttractionId = 13,
                },
                new AttractionImage
                {
                    Id = 26,
                    Url = "https://www.enflorencia.com/wp-content/uploads/2022/03/Torre-de-Pisa-scaled.webp",
                    AttractionId = 13,
                },
                //ID - 14
                new AttractionImage
                {
                    Id = 27,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipOBv4OY707Q1jUpkUW_lu4MRv75ri3B_fxG-rA=s680-w680-h510",
                    AttractionId = 14,
                },
                new AttractionImage
                {
                    Id = 28,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipOrHczOFXzZyn9DN5-L4TZ9ucl_l4iOD0ZkRZ7g=s680-w680-h510",
                    AttractionId = 14,
                },
                //ID - 15
                new AttractionImage
                {
                    Id = 29,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipO286FrRLq_CeLxc7kXGz7jFaw-tmr4iuzg9f80=s680-w680-h510",
                    AttractionId = 15,
                },
                new AttractionImage
                {
                    Id = 30,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipPocgU4qhUz3nmr4eDGvP3Ya8Q4kCzwuwICdGiT=s680-w680-h510",
                    AttractionId = 15,
                },
                //ID - 16
                new AttractionImage
                {
                    Id = 31,
                    Url = "https://www.civitatis.com/f/japon/tokio/galeria/paisajes-naturales-monte-fuji.jpg",
                    AttractionId = 16,
                },
                new AttractionImage
                {
                    Id = 32,
                    Url = "https://www.civitatis.com/f/japon/tokio/galeria/paisajes-teleferico-monte-fuji.jpg",
                    AttractionId = 16,
                },
                //ID - 17
                new AttractionImage
                {
                    Id = 33,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipNu6PXxGUoernEhHtqgVTj09KL_phSgcd5fSmRa=s680-w680-h510",
                    AttractionId = 17,
                },
                new AttractionImage
                {
                    Id = 34,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipNbX92cBVxHt3bQny0lEiihty0Vt3L5L7AwEUu6=s680-w680-h510",
                    AttractionId = 17,
                },
                //ID - 18
                new AttractionImage
                {
                    Id = 35,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipMLiaP8rTF2qRPZawoGtnsu6l3Pjdwr4RQ-SpFg=s680-w680-h510",
                    AttractionId = 18,
                },
                new AttractionImage
                {
                    Id = 36,
                    Url = "https://lh5.googleusercontent.com/p/AF1QipOuG4AaBIUaysro0dIGGGev-Nz8EEv80k-7bgGl=w243-h174-n-k-no-nu",
                    AttractionId = 18,
                },
                //ID - 19
                new AttractionImage
                {
                    Id = 37,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipNepH_nHqXcBDXVZcFZpRAUrlgHoPPJch2pYjtI=s680-w680-h510",
                    AttractionId = 19,
                },
                new AttractionImage
                {
                    Id = 38,
                    Url = "https://lh5.googleusercontent.com/p/AF1QipOtLAXkX8CSYQ5jJ8vDZ8bGYF8I3djt1IXyntFB=w243-h174-n-k-no-nu",
                    AttractionId = 19,
                },
                //ID - 20
                new AttractionImage
                {
                    Id = 39,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipNPX7gPFv9Zgo5bBDPQxPcsDGNjtDFYLHQPaM1d=s680-w680-h510",
                    AttractionId = 20,
                },
                new AttractionImage
                {
                    Id = 40,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipMxZlKoltgRKXSPwNMtOLBXqj4d9nTQ8t542bhC=s680-w680-h510",
                    AttractionId = 20,
                },
                //ID - 21
                new AttractionImage
                {
                    Id = 41,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipMHftgSCBlvyjxYphi4gLqDC_62WWvZvyy1EBuh=s680-w680-h510",
                    AttractionId = 21,
                },
                new AttractionImage
                {
                    Id = 42,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipPDW7FdkZAvBUhIGwbp63Ar10n22mJzlywhGFBS=s680-w680-h510",
                    AttractionId = 21,
                },
                //ID - 22
                new AttractionImage
                {
                    Id = 43,
                    Url = "https://t2.gstatic.com/licensed-image?q=tbn:ANd9GcT7TTlnBvYx42VGhXrI2ob9SfHnluzh5yrfQPPNLKI92pdQEG8hDIQ2gAsQZiEh7aVH",
                    AttractionId = 22,
                },
                new AttractionImage
                {
                    Id = 44,
                    Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT0Go-UrkIHVs6oAFZObJq_8LmoG3H8dD9eqQ&s",
                    AttractionId = 22,
                },
                //ID - 23
                new AttractionImage
                {
                    Id = 45,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipNr16xQjl9PqqLfiXee9kHtLv7xu-kvjiBPdeWw=s680-w680-h510",
                    AttractionId = 23,
                },
                new AttractionImage 
                {
                    Id = 46,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipOyIYnnHeQ08pfHozIDPedVmJBWabC8xjPy_G0-=s680-w680-h510",
                    AttractionId = 23,
                },
                //ID - 24
                new AttractionImage
                {
                    Id = 47,
                    Url = "https://lh5.googleusercontent.com/p/AF1QipPbVZakieiHTyFgD6K9nkC3bXaduMLl3AlR60yo=w341-h256-k-no",
                    AttractionId = 24,
                },
                new AttractionImage
                {
                    Id = 48,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipOdXc26iy6hvOoqUcNWsjQ77kelgUzH6GvpWgZM=s680-w680-h510-rw",
                    AttractionId = 24,
                },
                //ID - 25
                new AttractionImage
                {
                    Id = 49,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipNzQ9NmpdFMhGYxWz0AJCv9fxwJjEq4seRiax-z=s680-w680-h510",
                    AttractionId = 25,
                },
                new AttractionImage
                {
                    Id = 50,
                    Url = "https://lh3.googleusercontent.com/p/AF1QipP97SP8D3Kdk04f11uls9gPHDfQ58KYYVjHEKyo=s680-w680-h510",
                    AttractionId = 25,
                }
                );
            modelBuilder.Entity<AccommodationImage>().HasData
                (
                // Paris Hotel
                new AccommodationImage { Id = 1, Url = "https://example.com/paris_hotel_1.jpg", AccommodationId = 1 },
                new AccommodationImage { Id = 2, Url = "https://example.com/paris_hotel_2.jpg", AccommodationId = 1 },

                // Eiffel Inn
                new AccommodationImage { Id = 3, Url = "https://example.com/eiffel_inn_1.jpg", AccommodationId = 2 },
                new AccommodationImage { Id = 4, Url = "https://example.com/eiffel_inn_2.jpg", AccommodationId = 2 },

                // Tower Stay
                new AccommodationImage { Id = 5, Url = "https://example.com/tower_stay_1.jpg", AccommodationId = 3 },
                new AccommodationImage { Id = 6, Url = "https://example.com/tower_stay_2.jpg", AccommodationId = 3 },

                // Louvre Hotel
                new AccommodationImage { Id = 7, Url = "https://example.com/louvre_hotel_1.jpg", AccommodationId = 4 },
                new AccommodationImage { Id = 8, Url = "https://example.com/louvre_hotel_2.jpg", AccommodationId = 4 },

                // Art Stay
                new AccommodationImage { Id = 9, Url = "https://example.com/art_stay_1.jpg", AccommodationId = 5 },
                new AccommodationImage { Id = 10, Url = "https://example.com/art_stay_2.jpg", AccommodationId = 5 },

                // Grand Canyon Lodge
                new AccommodationImage { Id = 11, Url = "https://example.com/grand_canyon_lodge_1.jpg", AccommodationId = 6 },
                new AccommodationImage { Id = 12, Url = "https://example.com/grand_canyon_lodge_2.jpg", AccommodationId = 6 },

                // Canyon View Inn
                new AccommodationImage { Id = 13, Url = "https://example.com/canyon_view_inn_1.jpg", AccommodationId = 7 },
                new AccommodationImage { Id = 14, Url = "https://example.com/canyon_view_inn_2.jpg", AccommodationId = 7 },

                // Canyon Stay
                new AccommodationImage { Id = 15, Url = "https://example.com/canyon_stay_1.jpg", AccommodationId = 8 },
                new AccommodationImage { Id = 16, Url = "https://example.com/canyon_stay_2.jpg", AccommodationId = 8 },

                // Liberty Hotel
                new AccommodationImage { Id = 17, Url = "https://example.com/liberty_hotel_1.jpg", AccommodationId = 9 },
                new AccommodationImage { Id = 18, Url = "https://example.com/liberty_hotel_2.jpg", AccommodationId = 9 },

                // Freedom Inn
                new AccommodationImage { Id = 19, Url = "https://example.com/freedom_inn_1.jpg", AccommodationId = 10 },
                new AccommodationImage { Id = 20, Url = "https://example.com/freedom_inn_2.jpg", AccommodationId = 10 },

                // Liberty Stay
                new AccommodationImage { Id = 21, Url = "https://example.com/liberty_stay_1.jpg", AccommodationId = 11 },
                new AccommodationImage { Id = 22, Url = "https://example.com/liberty_stay_2.jpg", AccommodationId = 11 },

                // Yellowstone Lodge
                new AccommodationImage { Id = 23, Url = "https://example.com/yellowstone_lodge_1.jpg", AccommodationId = 12 },
                new AccommodationImage { Id = 24, Url = "https://example.com/yellowstone_lodge_2.jpg", AccommodationId = 12 },

                // Geyser Inn
                new AccommodationImage { Id = 25, Url = "https://example.com/geyser_inn_1.jpg", AccommodationId = 13 },
                new AccommodationImage { Id = 26, Url = "https://example.com/geyser_inn_2.jpg", AccommodationId = 13 },

                // Park Stay
                new AccommodationImage { Id = 27, Url = "https://example.com/park_stay_1.jpg", AccommodationId = 14 },
                new AccommodationImage { Id = 28, Url = "https://example.com/park_stay_2.jpg", AccommodationId = 14 },

                // Disney Hotel
                new AccommodationImage { Id = 29, Url = "https://example.com/disney_hotel_1.jpg", AccommodationId = 15 },
                new AccommodationImage { Id = 30, Url = "https://example.com/disney_hotel_2.jpg", AccommodationId = 15 },

                // Magic Inn
                new AccommodationImage { Id = 31, Url = "https://example.com/magic_inn_1.jpg", AccommodationId = 16 },
                new AccommodationImage { Id = 32, Url = "https://example.com/magic_inn_2.jpg", AccommodationId = 16 },

                // Disney Stay
                new AccommodationImage { Id = 33, Url = "https://example.com/disney_stay_1.jpg", AccommodationId = 17 },
                new AccommodationImage { Id = 34, Url = "https://example.com/disney_stay_2.jpg", AccommodationId = 17 },

                // Golden Gate Hotel
                new AccommodationImage { Id = 35, Url = "https://example.com/golden_gate_hotel_1.jpg", AccommodationId = 18 },
                new AccommodationImage { Id = 36, Url = "https://example.com/golden_gate_hotel_2.jpg", AccommodationId = 18 },

                // Bridge View Inn
                new AccommodationImage { Id = 37, Url = "https://example.com/bridge_view_inn_1.jpg", AccommodationId = 19 },
                new AccommodationImage { Id = 38, Url = "https://example.com/bridge_view_inn_2.jpg", AccommodationId = 19 },

                // Gate Stay
                new AccommodationImage { Id = 39, Url = "https://example.com/gate_stay_1.jpg", AccommodationId = 20 },
                new AccommodationImage { Id = 40, Url = "https://example.com/gate_stay_2.jpg", AccommodationId = 20 },

                // Colosseum Hotel
                new AccommodationImage { Id = 41, Url = "https://example.com/colosseum_hotel_1.jpg", AccommodationId = 21 },
                new AccommodationImage { Id = 42, Url = "https://example.com/colosseum_hotel_2.jpg", AccommodationId = 21 },

                // Gladiator Inn
                new AccommodationImage { Id = 43, Url = "https://example.com/gladiator_inn_1.jpg", AccommodationId = 22 },
                new AccommodationImage { Id = 44, Url = "https://example.com/gladiator_inn_2.jpg", AccommodationId = 22 },

                // Rome Stay
                new AccommodationImage { Id = 45, Url = "https://example.com/rome_stay_1.jpg", AccommodationId = 23 },
                new AccommodationImage { Id = 46, Url = "https://example.com/rome_stay_2.jpg", AccommodationId = 23 },

                // Venice Hotel
                new AccommodationImage { Id = 47, Url = "https://example.com/venice_hotel_1.jpg", AccommodationId = 24 },
                new AccommodationImage { Id = 48, Url = "https://example.com/venice_hotel_2.jpg", AccommodationId = 24 },

                // Canal View Inn
                new AccommodationImage { Id = 49, Url = "https://example.com/canal_view_inn_1.jpg", AccommodationId = 25 },
                new AccommodationImage { Id = 50, Url = "https://example.com/canal_view_inn_2.jpg", AccommodationId = 25 },

                // Venice Stay
                new AccommodationImage { Id = 51, Url = "https://example.com/venice_stay_1.jpg", AccommodationId = 26 },
                new AccommodationImage { Id = 52, Url = "https://example.com/venice_stay_2.jpg", AccommodationId = 26 },

                // Pisa Hotel
                new AccommodationImage { Id = 53, Url = "https://example.com/pisa_hotel_1.jpg", AccommodationId = 27 },
                new AccommodationImage { Id = 54, Url = "https://example.com/pisa_hotel_2.jpg", AccommodationId = 27 },

                // Leaning Inn
                new AccommodationImage { Id = 55, Url = "https://example.com/leaning_inn_1.jpg", AccommodationId = 28 },
                new AccommodationImage { Id = 56, Url = "https://example.com/leaning_inn_2.jpg", AccommodationId = 28 },

                // Pisa Stay
                new AccommodationImage { Id = 57, Url = "https://example.com/pisa_stay_1.jpg", AccommodationId = 29 },
                new AccommodationImage { Id = 58, Url = "https://example.com/pisa_stay_2.jpg", AccommodationId = 29 },

                // Florence Hotel
                new AccommodationImage { Id = 59, Url = "https://example.com/florence_hotel_1.jpg", AccommodationId = 30 },
                new AccommodationImage { Id = 60, Url = "https://example.com/florence_hotel_2.jpg", AccommodationId = 30 },

                // Cathedral Inn
                new AccommodationImage { Id = 61, Url = "https://example.com/cathedral_inn_1.jpg", AccommodationId = 31 },
                new AccommodationImage { Id = 62, Url = "https://example.com/cathedral_inn_2.jpg", AccommodationId = 31 },

                // Florence Stay
                new AccommodationImage { Id = 63, Url = "https://example.com/florence_stay_1.jpg", AccommodationId = 32 },
                new AccommodationImage { Id = 64, Url = "https://example.com/florence_stay_2.jpg", AccommodationId = 32 },

                // Amalfi Hotel
                new AccommodationImage { Id = 65, Url = "https://example.com/amalfi_hotel_1.jpg", AccommodationId = 33 },
                new AccommodationImage { Id = 66, Url = "https://example.com/amalfi_hotel_2.jpg", AccommodationId = 33 },

                // Coast View Inn
                new AccommodationImage { Id = 67, Url = "https://example.com/coast_view_inn_1.jpg", AccommodationId = 34 },
                new AccommodationImage { Id = 68, Url = "https://example.com/coast_view_inn_2.jpg", AccommodationId = 34 },

                // Amalfi Stay
                new AccommodationImage { Id = 69, Url = "https://example.com/amalfi_stay_1.jpg", AccommodationId = 35 },
                new AccommodationImage { Id = 70, Url = "https://example.com/amalfi_stay_2.jpg", AccommodationId = 35 },

                // Mount Fuji Hotel
                new AccommodationImage { Id = 71, Url = "https://example.com/mount_fuji_hotel_1.jpg", AccommodationId = 36 },
                new AccommodationImage { Id = 72, Url = "https://example.com/mount_fuji_hotel_2.jpg", AccommodationId = 36 },

                // Fuji View Inn
                new AccommodationImage { Id = 73, Url = "https://example.com/fuji_view_inn_1.jpg", AccommodationId = 37 },
                new AccommodationImage { Id = 74, Url = "https://example.com/fuji_view_inn_2.jpg", AccommodationId = 37 },

                // Fuji Stay
                new AccommodationImage { Id = 75, Url = "https://example.com/fuji_stay_1.jpg", AccommodationId = 38 },
                new AccommodationImage { Id = 76, Url = "https://example.com/fuji_stay_2.jpg", AccommodationId = 38 },

                // Tokyo Tower Hotel
                new AccommodationImage { Id = 77, Url = "https://example.com/tokyo_tower_hotel_1.jpg", AccommodationId = 39 },
                new AccommodationImage { Id = 78, Url = "https://example.com/tokyo_tower_hotel_2.jpg", AccommodationId = 39 },

                // Tower View Inn
                new AccommodationImage { Id = 79, Url = "https://example.com/tower_view_inn_1.jpg", AccommodationId = 40 },
                new AccommodationImage { Id = 80, Url = "https://example.com/tower_view_inn_2.jpg", AccommodationId = 40 },

                // Tokyo Stay
                new AccommodationImage { Id = 81, Url = "https://example.com/tokyo_stay_1.jpg", AccommodationId = 41 },
                new AccommodationImage { Id = 82, Url = "https://example.com/tokyo_stay_2.jpg", AccommodationId = 41 },

                // Kyoto Palace Hotel
                new AccommodationImage { Id = 83, Url = "https://example.com/kyoto_palace_hotel_1.jpg", AccommodationId = 42 },
                new AccommodationImage { Id = 84, Url = "https://example.com/kyoto_palace_hotel_2.jpg", AccommodationId = 42 },

                // Imperial Inn
                new AccommodationImage { Id = 85, Url = "https://example.com/imperial_inn_1.jpg", AccommodationId = 43 },
                new AccommodationImage { Id = 86, Url = "https://example.com/imperial_inn_2.jpg", AccommodationId = 43 },

                // Kyoto Stay
                new AccommodationImage { Id = 87, Url = "https://example.com/kyoto_stay_1.jpg", AccommodationId = 44 },
                new AccommodationImage { Id = 88, Url = "https://example.com/kyoto_stay_2.jpg", AccommodationId = 44 },

                // Hiroshima Hotel
                new AccommodationImage { Id = 89, Url = "https://example.com/hiroshima_hotel_1.jpg", AccommodationId = 45 },
                new AccommodationImage { Id = 90, Url = "https://example.com/hiroshima_hotel_2.jpg", AccommodationId = 45 },

                // Peace Inn
                new AccommodationImage { Id = 91, Url = "https://example.com/peace_inn_1.jpg", AccommodationId = 46 },
                new AccommodationImage { Id = 92, Url = "https://example.com/peace_inn_2.jpg", AccommodationId = 46 },

                // Hiroshima Stay
                new AccommodationImage { Id = 93, Url = "https://example.com/hiroshima_stay_1.jpg", AccommodationId = 47 },
                new AccommodationImage { Id = 94, Url = "https://example.com/hiroshima_stay_2.jpg", AccommodationId = 47 },

                // Itsukushima Hotel
                new AccommodationImage { Id = 95, Url = "https://example.com/itsukushima_hotel_1.jpg", AccommodationId = 48 },
                new AccommodationImage { Id = 96, Url = "https://example.com/itsukushima_hotel_2.jpg", AccommodationId = 48 },

                // Shrine View Inn
                new AccommodationImage { Id = 97, Url = "https://example.com/shrine_view_inn_1.jpg", AccommodationId = 49 },
                new AccommodationImage { Id = 98, Url = "https://example.com/shrine_view_inn_2.jpg", AccommodationId = 49 },

                // Shrine Stay
                new AccommodationImage { Id = 99, Url = "https://example.com/shrine_stay_1.jpg", AccommodationId = 50 },
                new AccommodationImage { Id = 100, Url = "https://example.com/shrine_stay_2.jpg", AccommodationId = 50 },

                // Sydney Opera Hotel
                new AccommodationImage { Id = 101, Url = "https://example.com/sydney_opera_hotel_1.jpg", AccommodationId = 51 },
                new AccommodationImage { Id = 102, Url = "https://example.com/sydney_opera_hotel_2.jpg", AccommodationId = 51 },

                // Harbour Inn
                new AccommodationImage { Id = 103, Url = "https://example.com/harbour_inn_1.jpg", AccommodationId = 52 },
                new AccommodationImage { Id = 104, Url = "https://example.com/harbour_inn_2.jpg", AccommodationId = 52 },

                // Opera Stay
                new AccommodationImage { Id = 105, Url = "https://example.com/opera_stay_1.jpg", AccommodationId = 53 },
                new AccommodationImage { Id = 106, Url = "https://example.com/opera_stay_2.jpg", AccommodationId = 53 },

                // Great Barrier Reef Hotel
                new AccommodationImage { Id = 107, Url = "https://example.com/great_barrier_reef_hotel_1.jpg", AccommodationId = 54 },
                new AccommodationImage { Id = 108, Url = "https://example.com/great_barrier_reef_hotel_2.jpg", AccommodationId = 54 },

                // Reef Inn
                new AccommodationImage { Id = 109, Url = "https://example.com/reef_inn_1.jpg", AccommodationId = 55 },
                new AccommodationImage { Id = 110, Url = "https://example.com/reef_inn_2.jpg", AccommodationId = 55 },

                // Reef Stay
                new AccommodationImage { Id = 111, Url = "https://example.com/reef_stay_1.jpg", AccommodationId = 56 },
                new AccommodationImage { Id = 112, Url = "https://example.com/reef_stay_2.jpg", AccommodationId = 56 },

                // Uluru Hotel
                new AccommodationImage { Id = 113, Url = "https://example.com/uluru_hotel_1.jpg", AccommodationId = 57 },
                new AccommodationImage { Id = 114, Url = "https://example.com/uluru_hotel_2.jpg", AccommodationId = 57 },

                // Rock Inn
                new AccommodationImage { Id = 115, Url = "https://example.com/rock_inn_1.jpg", AccommodationId = 58 },
                new AccommodationImage { Id = 116, Url = "https://example.com/rock_inn_2.jpg", AccommodationId = 58 },

                // Uluru Stay
                new AccommodationImage { Id = 117, Url = "https://example.com/uluru_stay_1.jpg", AccommodationId = 59 },
                new AccommodationImage { Id = 118, Url = "https://example.com/uluru_stay_2.jpg", AccommodationId = 59 },

                // Great Wall Hotel
                new AccommodationImage { Id = 119, Url = "https://example.com/great_wall_hotel_1.jpg", AccommodationId = 60 },
                new AccommodationImage { Id = 120, Url = "https://example.com/great_wall_hotel_2.jpg", AccommodationId = 60 },

                // Wall View Inn
                new AccommodationImage { Id = 121, Url = "https://example.com/wall_view_inn_1.jpg", AccommodationId = 61 },
                new AccommodationImage { Id = 122, Url = "https://example.com/wall_view_inn_2.jpg", AccommodationId = 61 },

                // Wall Stay
                new AccommodationImage { Id = 123, Url = "https://example.com/wall_stay_1.jpg", AccommodationId = 62 },
                new AccommodationImage { Id = 124, Url = "https://example.com/wall_stay_2.jpg", AccommodationId = 62 },

                // Forbidden City Hotel
                new AccommodationImage { Id = 125, Url = "https://example.com/forbidden_city_hotel_1.jpg", AccommodationId = 63 },
                new AccommodationImage { Id = 126, Url = "https://example.com/forbidden_city_hotel_2.jpg", AccommodationId = 63 },

                // Palace Inn
                new AccommodationImage { Id = 127, Url = "https://example.com/palace_inn_1.jpg", AccommodationId = 64 },
                new AccommodationImage { Id = 128, Url = "https://example.com/palace_inn_2.jpg", AccommodationId = 64 },

                // Forbidden Stay
                new AccommodationImage { Id = 129, Url = "https://example.com/forbidden_stay_1.jpg", AccommodationId = 65 },
                new AccommodationImage { Id = 130, Url = "https://example.com/forbidden_stay_2.jpg", AccommodationId = 65 },

                // Terracotta Warriors Hotel
                new AccommodationImage { Id = 131, Url = "https://example.com/terracotta_warriors_hotel_1.jpg", AccommodationId = 66 },
                new AccommodationImage { Id = 132, Url = "https://example.com/terracotta_warriors_hotel_2.jpg", AccommodationId = 66 },

                // Warrior Inn
                new AccommodationImage { Id = 133, Url = "https://example.com/warrior_inn_1.jpg", AccommodationId = 67 },
                new AccommodationImage { Id = 134, Url = "https://example.com/warrior_inn_2.jpg", AccommodationId = 67 },

                // Warrior Stay
                new AccommodationImage { Id = 135, Url = "https://example.com/warrior_stay_1.jpg", AccommodationId = 68 },
                new AccommodationImage { Id = 136, Url = "https://example.com/warrior_stay_2.jpg", AccommodationId = 68 },

                // Machu Picchu Hotel
                new AccommodationImage { Id = 137, Url = "https://example.com/machu_picchu_hotel_1.jpg", AccommodationId = 69 },
                new AccommodationImage { Id = 138, Url = "https://example.com/machu_picchu_hotel_2.jpg", AccommodationId = 69 },

                // Inca Inn
                new AccommodationImage { Id = 139, Url = "https://example.com/inca_inn_1.jpg", AccommodationId = 70 },
                new AccommodationImage { Id = 140, Url = "https://example.com/inca_inn_2.jpg", AccommodationId = 70 },

                // Inca Stay
                new AccommodationImage { Id = 141, Url = "https://example.com/inca_stay_1.jpg", AccommodationId = 71 },
                new AccommodationImage { Id = 142, Url = "https://example.com/inca_stay_2.jpg", AccommodationId = 71 },

                // Cusco Hotel
                new AccommodationImage { Id = 143, Url = "https://example.com/cusco_hotel_1.jpg", AccommodationId = 72 },
                new AccommodationImage { Id = 144, Url = "https://example.com/cusco_hotel_2.jpg", AccommodationId = 72 },

                // Andes Inn
                new AccommodationImage { Id = 145, Url = "https://example.com/andes_inn_1.jpg", AccommodationId = 73 },
                new AccommodationImage { Id = 146, Url = "https://example.com/andes_inn_2.jpg", AccommodationId = 73 },

                // Andes Stay
                new AccommodationImage { Id = 147, Url = "https://example.com/andes_stay_1.jpg", AccommodationId = 74 },
                new AccommodationImage { Id = 148, Url = "https://example.com/andes_stay_2.jpg", AccommodationId = 74 },

                // Lake Titicaca Hotel
                new AccommodationImage { Id = 149, Url = "https://example.com/lake_titicaca_hotel_1.jpg", AccommodationId = 75 },
                new AccommodationImage { Id = 150, Url = "https://example.com/lake_titicaca_hotel_2.jpg", AccommodationId = 75 }
                );
        }
    }
}
