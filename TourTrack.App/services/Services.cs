using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTrack.Models;

namespace TourTrack.App.services
{
    public class Services
    {
        private readonly HttpClient _client;

        public Services()
        {
            _client = App.HttpClient;
        }

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

        public async Task<List<Accommodation>> GetAccomodtionsAsync()
        {
            try
            {
                using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));

                var response = await _client.GetAsync("api/Accommodation", cts.Token);
                response.EnsureSuccessStatusCode();

                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Accommodation>>(jsonResponse);
            }
            catch (Exception)
            {
                Console.WriteLine("Sem conexão com a internet");
                return new List<Accommodation>();
            }
        }
        public async Task<List<Accommodation>> GetRandomHotels()
        {
            try
            {
                using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));

                var response = await _client.GetAsync("api/Accommodation/GetRandomHotels", cts.Token);
                response.EnsureSuccessStatusCode();

                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Accommodation>>(jsonResponse);
            }
            catch (Exception)
            {
                Console.WriteLine("Sem conexão com a internet");
                return new List<Accommodation>();
            }
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
            catch (Exception)
            {
                Console.WriteLine("Sem conexão com a internet");
                return new List<Attraction>();
            }
        }
    }
}
