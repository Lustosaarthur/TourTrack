using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTrack.Models;

namespace TourTrack.App.services
{   
    public class LoadingService
    {
        private readonly Services _service;
        private int _currentPage = 0;
        private const int PageSize = 10; // Número de itens a carregar por vez

        public LoadingService()
        {
            _service = new Services();
        }

        public async Task<List<Attraction>> LoadMoreAttractionsAsync(List<Attraction> allAttractions)
        {
            var itemsToSkip = _currentPage * PageSize;
            var items = allAttractions.Skip(itemsToSkip).Take(PageSize).ToList();

            _currentPage++;
            return items;
        }

        public async Task<List<Attraction>> GetAllAttractionsAsync()
        {
            return await _service.GetAttractionsAsync();
        }
    }
}
