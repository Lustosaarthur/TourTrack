using Newtonsoft.Json;
using TourTrack.Models;

namespace RequestTest
{
    internal class Program
    {
        private readonly HttpClient _client;
        public string url = "http://localhost:5033/api/Attractions";
        //api/Accommodation
        //api/Countries

        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var attractionService = new AttractionService();
            var accommodationService = new AttractionService();
            var countryService = new AttractionService();
            var attractions = await attractionService.GetAttractionsAsync("api/Attractions");
            var accommodations = await attractionService.GetAccomodtionsAsync("api/Accommodation");
            var countries = await attractionService.GetCountriesAsync("api/Countries");

            foreach (var attraction in attractions)
            {
                Console.WriteLine($"Name: {attraction.Name}, Description: {attraction.Description} Image: {attraction.Images}");
            }
            Console.WriteLine("Hoteis");
            foreach (var accommodation in accommodations)
            {
                Console.WriteLine($"Name: {accommodation.Name}, Description: {accommodation.Description}");
            }
            Console.WriteLine("Paises");
            foreach (var country in countries)
            {
                Console.WriteLine($"Name: {country.Name}");
            }
           
        }
    }
}
