using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TourTrack.App.AppModels;
using TourTrack.App.services;
using TourTrack.App.services.Attractions;
using TourTrack.App.services.CategoryMenu;
using TourTrack.App.Views;
using TourTrack.Models;

namespace TourTrack.App.ViewModels
{
    public partial class ExplorePageViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _allScreen = true;
        [ObservableProperty]
        private bool _errorMessage = false;
        [ObservableProperty]
        private string _parameterCountry = "EUA";
        [ObservableProperty]
        private bool isLoading;
        [ObservableProperty]
        private bool _switchCll = false;
        [ObservableProperty]
        private bool _cllIsVisible = true;

        [ObservableProperty]
        private List<Attraction> _bestAttractions;
        [ObservableProperty]
        private List<Attraction> _bestAttractionsOfCountry;
        [ObservableProperty]
        private List<Attraction> _listAttractionsMby;
        [ObservableProperty]
        private List<CountryCategory> _listCountries;

        private readonly AttractionService _service;
        private readonly CountryCategoryService _countryService;

        public ExplorePageViewModel()
        {
            _service = new AttractionService();
            _countryService = new CountryCategoryService();
            LoadData().ConfigureAwait(false);
        }
        [RelayCommand]
        public async Task LoadData()
        {
            IsLoading = true;
            BestAttractions = await _service.GetAttractionsByRating(4);
            ListAttractionsMby = await _service.GetRecomendedAttractions();
            BestAttractionsOfCountry = await _service.GetAttractionByCountry(2);
            ListCountries = _countryService.GetCountryModels();

            var total = BestAttractions.Count + BestAttractionsOfCountry.Count + ListAttractionsMby.Count;
            if (total == 0)
                NoInternet();
            IsLoading = false;
        }
        [RelayCommand]
        public void GoToDetail(Attraction Attraction)
        {
            var parameter = new Dictionary<string, object>()
            {
                { "Attraction", Attraction}
            };
            Shell.Current.GoToAsync("detail", parameter);
        }

        [RelayCommand]
        private async Task CllViewSwicth(string parameter)
        {
            SetSwitchState(true, false);
            var countryCode = GetCountryCode(parameter);
            if (countryCode != null)
            {
                ParameterCountry = parameter;
                BestAttractionsOfCountry = await _service.GetAttractionByCountry(countryCode.Value);
            }
            else
                Console.WriteLine($"Código de país não encontrado para: {parameter}");
            SetSwitchState(false, true);
        }
        private void SetSwitchState(bool isSwitchCll, bool isCllIsVisible)
        {
            SwitchCll = isSwitchCll;
            CllIsVisible = isCllIsVisible;
        }
        private int? GetCountryCode(string parameter)
        {
            return parameter switch
            {
                "France" => 1,
                "EUA" => 2,
                "Italy" => 3,
                "Japan" => 4,
                "Australia" => 5,
                _ => null
            };
        }
        public void NoInternet()
        {
            AllScreen = false;
            ErrorMessage = true;
        }
    }
}
