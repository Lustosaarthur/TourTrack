using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTrack.Models;

namespace TourTrack.App.services.Accommodations
{
    public class AccommodationService
    {
        private readonly HttpClient _client;

        public AccommodationService()
        {
            _client = new HttpClient();
        }

        //api/Accommodation
        public async Task<List<Accommodation>> GetAccommodations()
        {
            var response = await _client.GetAsync("api/Accommodation");
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Accommodation>>(jsonResponse);
        }

        //api/Accommodation/{id}
        public async Task<Accommodation> GetAccommodation(int id)
        {
            var response = await _client.GetAsync($"api/Accommodation/{id}");
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Accommodation>(jsonResponse);
        }

        //api/Accommodation/{CountryId}/GetAttractionByCountry
        public async Task<List<Accommodation>> GetAttractionByCountry(int CountryId)
        {
            var response = await _client.GetAsync($"api/Accommodation/{CountryId}/GetAttractionByCountry");
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Accommodation>>(jsonResponse);
        }
    }
}
