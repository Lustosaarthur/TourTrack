using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTrack.App.Repositories;
using TourTrack.App.services;
using TourTrack.App.services.Messages;
using TourTrack.Models;
using TourTrack.Models.Persistence;

namespace TourTrack.App.ViewModels
{
    public partial class FavoritiesPageViewModel : ObservableObject
    {
        private readonly TourTrackAppContext _appContext;
        private readonly IAttractionsDbRepository _repository;
        [ObservableProperty]
        private string _searchKey;

        private List<Attraction> _allAttractions;
        [ObservableProperty]
        private List<Attraction> _filtredList; 
        [ObservableProperty]
        public bool isLoading;
        private readonly Services _service;
        public FavoritiesPageViewModel()
        {
            _appContext = new TourTrackAppContext();
            _repository = new AttractionsDbRepository(_appContext);
            _service = new Services();

            MessengerHelper.ReloadDataRequested += OnReloadData;
            LoadDataAsync().ConfigureAwait(false);
        }
        [RelayCommand]
        public void GoToDetail(Attraction attraction)
        {
            var Parameter = new Dictionary<string, object>()
            {
                {"attraction", attraction }
            };
            Shell.Current.GoToAsync("detail", Parameter);
        }
        public async Task LoadDataAsync()
        {
            IsLoading = true;
            try
            {
                _allAttractions = await Task.Run(() => (List<Attraction>)_repository.GetAllAtractions());
                if (_allAttractions == null)
                    Console.WriteLine("Nulo");
                else
                    FiltredList = _allAttractions.ToList();
            }
            finally
            {
                IsLoading = false;
            }
        }

        [RelayCommand]
        public void TextSearch()
        {
            FiltredList = _allAttractions
                 .Where(
                 a => a.Name.ToLower().Contains(SearchKey.ToLower())
                 ).ToList();
        }
        public void OnReloadData(ReloadDataMessage message)
        {
            LoadDataAsync().ConfigureAwait(false);
        }
    }
}
