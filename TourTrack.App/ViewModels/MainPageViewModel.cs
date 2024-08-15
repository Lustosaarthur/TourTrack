using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TourTrack.App.AppModels;
using TourTrack.App.services;
using TourTrack.App.services.Attractions;
using TourTrack.App.services.CategoryMenu;
using TourTrack.Models;
using TourTrack.Models.Images;

namespace TourTrack.App.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _allScreen = true;
        [ObservableProperty]
        private bool _errorMessage = false;
        [ObservableProperty]
        private bool _switchCll = false;
        [ObservableProperty]
        private string _searchKey;
        [ObservableProperty]
        private bool _searchCllIsVisible;
        public Services ApiServices { get; private set; }
        public CategoryMenuService Service { get; private set; }
        [ObservableProperty]
        public string _keyWord;
        [ObservableProperty]
        private bool _isLoading;
        [ObservableProperty]
        private bool _showScreen = false;
        public ICommand TrocaCollectionViewCommand { get; }
        [ObservableProperty]
        private List<CategoryMenuModels> _categoriesMenuModels;
        
        private List<Attraction> _backupList;
        [ObservableProperty]
        private List<Attraction> _allAttractions;
        [ObservableProperty]
        private List<Attraction> _popularAttractions;
        [ObservableProperty]
        private List<Attraction> _recomendedAttractions;
        [ObservableProperty]
        private List<Accommodation> _randomListHotels;
        [ObservableProperty]
        private List<Attraction> _filtredList;
        [ObservableProperty]
        private List<Accommodation> _allAccommodations;

        [ObservableProperty]
        private bool _isVisibleAtt; //recomendado
        [ObservableProperty]
        private bool _isVisiblePppl; //popular
        [ObservableProperty]
        private bool _isVisibleAll; //Principais
        public MainPageViewModel()
        {
            Service = new CategoryMenuService();
            ApiServices = new Services();
            IsVisibleAtt = true;
            SearchCllIsVisible = false;
            TrocaCollectionViewCommand = new Command<string>(async parametro =>
            {
                await ExecutarTrocaCollectionViewCommandAsync(parametro);
            });

            LoadDataAsync().ConfigureAwait(false);
            
        }
        private async Task ExecutarTrocaCollectionViewCommandAsync(string parameter)
        {
            SetVisibilityAndLoading(parameter);
            switch (parameter)
            {
                case "Todas":
                    IsLoading = true;
                    AllAttractions = await ApiServices.GetAttractionsAsync();
                    IsLoading = false;
                    break;
                case "Popular":
                    IsLoading = true;
                    PopularAttractions = await ApiServices.GetAttractionsByRating(5);
                    IsLoading = true;
                    break;
                case "Recomended":
                    break;
            }
            SwitchCll = false;
            IsLoading = false;
        }
        private void SetVisibilityAndLoading(string parameter)
        {
            IsVisibleAll = parameter == "Todas";
            IsVisibleAtt = parameter == "Recomended";
            IsVisiblePppl = parameter == "Popular";
            IsLoading = true;
            SwitchCll = true;
        }
        public async Task LoadDataAsync()
        {
            IsLoading = true;
            RecomendedAttractions = await ApiServices.GetRecomendedAttractions();
            CategoriesMenuModels = Service.GetCategoryMenuModels();
            RandomListHotels = await ApiServices.GetRandomHotels();
            if (RecomendedAttractions.Count == 0)
                NoInternet();
            IsLoading = false;
            ShowScreen = true;
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
        public void GoToDetailAcc(Accommodation accommodation)
        {
            var parameter = new Dictionary<string, object>()
            {
                { "accommodation", accommodation}
            };
            Shell.Current.GoToAsync("detailacc", parameter);
        }
        [RelayCommand]
        public void TextSearch()
        {
            Pesquisando();
            if (string.IsNullOrWhiteSpace(SearchKey))
            {
                FiltredList = new List<Attraction>();
                OnEntryUnfocused();
            }
            else
            {
                FiltredList = _backupList
                     .Where(a => a.Name.ToLower().Contains(SearchKey.ToLower()))
                     .ToList();
            }
        }
        public async Task GetBackUp()
        {
            _backupList = await ApiServices.GetAttractionsAsync();
        }
        public async void OnEntryFocused()
        {
            if (_backupList == null || !_backupList.Any())
            {
                await GetBackUp();
            }
            FiltredList = _backupList;
        }
        public void ClearList()
        {
            FiltredList = new List<Attraction>();
        }
        
        public void OnEntryUnfocused()
        {
            ClearList();
            if(SearchKey.Length > 0)
            {
                SearchKey = "";
                Livre(); 
            }
            else
            { }
        }
        public void Pesquisando()
        {
            ShowScreen = false;
            SearchCllIsVisible = true;
        }
        public void Livre()
        {
            ShowScreen = true;
            SearchCllIsVisible = false;
        }
        [RelayCommand]
        public void Unfocus()
        {
            OnEntryUnfocused();
        }
        public void NoInternet()
        {
            AllScreen = false;
            ErrorMessage = true;
        }
    }
}
