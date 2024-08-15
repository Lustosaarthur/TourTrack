using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTrack.Models;

namespace RequestTest
{
    public class AttractionService
    {
        private readonly HttpClient _client;
        private readonly string _baseUrl = "http://localhost:5033/";

        public AttractionService()
        {
            _client = new HttpClient { BaseAddress = new Uri(_baseUrl) };
        }

        public async Task<List<Attraction>> GetAttractionsAsync(string url)
        {
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Attraction>>(jsonResponse);
        }
        public async Task<List<Accommodation>> GetAccomodtionsAsync(string url)
        {
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Accommodation>>(jsonResponse);
        }

        public async Task<List<Country>> GetCountriesAsync(string url)
        {
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Country>>(jsonResponse);
        }
    }
}
