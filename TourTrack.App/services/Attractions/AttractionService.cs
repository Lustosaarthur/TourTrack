using Newtonsoft.Json;
using System.Reflection;
using TourTrack.Models;

namespace TourTrack.App.services.Attractions
{
    public class AttractionService
    {
        private readonly HttpClient _client;

        public AttractionService()
        {
            _client = App.HttpClient;

        }

        //api/Attractions
        public async Task<List<Attraction>> GetAttractionsAsync()
        {
            try
            {
                using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));
                var response = await _client.GetAsync("api/Attractions", cts.Token);
                response.EnsureSuccessStatusCode();

                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Attraction>>(jsonResponse);
            }
            catch (Exception)
            {
                Console.WriteLine("Sem conexão com a internet");
                return new List<Attraction>();
            }
        }

        //api/Attractions/{int CountryId}/GetAttractionByCountry
        public async Task<List<Attraction>> GetAttractionByCountry(int CountryId)
        {
            try
            {
                using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));
                var response = await _client.GetAsync($"api/Attractions/{CountryId}/GetAttractionByCountry", cts.Token);
                response.EnsureSuccessStatusCode();

                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Attraction>>(jsonResponse);
            }
            catch (Exception)
            {
                Console.WriteLine("Sem conexão com a internet");
                return new List<Attraction>();
            }

        }

        //api/Attractions/{int id}
        public async Task<Attraction> GetAttractionById(int id)
        {
            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));
            var response = await _client.GetAsync($"api/Attractions/{id}", cts.Token);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Attraction>(jsonResponse);
        }
        public async Task<List<Attraction>> GetAttractionsByRating(double rating)
        {
            try
            {
                using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));
                var response = await _client.GetAsync($"api/Attractions/{rating}/GetAttractionsByRating", cts.Token);
                response.EnsureSuccessStatusCode();
                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Attraction>>(jsonResponse);
            }
            catch (Exception)
            {
                Console.WriteLine("Sem conexão com a internet");
                return new List<Attraction>();
            }
        }
        public async Task<List<Attraction>> GetRecomendedAttractions()
        {
            try
            {
                using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));
                var response = await _client.GetAsync($"api/Attractions/GetRecomended", cts.Token);
                response.EnsureSuccessStatusCode();

                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Attraction>>(jsonResponse);
            }
            catch(Exception)
            {
                Console.WriteLine("Sem conexão com a internet");
                return new List<Attraction>();
            }
        }
    }
}

