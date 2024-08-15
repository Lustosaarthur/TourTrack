using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTrack.App.Repositories;
using TourTrack.App.services.Alerts;
using TourTrack.App.services.Messages;
using TourTrack.Models;
using TourTrack.Models.Persistence;

namespace TourTrack.App.ViewModels.Details
{
    [QueryProperty(nameof(Attraction), "Attraction")]
    public partial class DetailViewPageViewModel : ObservableObject
    {
        private readonly IAlertService _alertService;
        private IAttractionsDbRepository _repository;
        private TourTrackAppContext _appContext;
        [ObservableProperty]
        private bool _isLoading;
        private Attraction _attraction;
        public Attraction Attraction
        {
            get { return _attraction; }
            set
            {
                if (_attraction != value)
                {
                    _attraction = value;
                    OnPropertyChanged();
                    while (_attraction == null)
                    {
                        IsLoading = true;
                    }
                    if (_attraction != null)
                    {
                        IsLoading = false;
                    }
                }
            }
        }

        public DetailViewPageViewModel()
        {
            _appContext = new TourTrackAppContext();
            _alertService = new AlertService();
            _repository = new AttractionsDbRepository(_appContext);
        }

        [RelayCommand]
        public void GoBack()
        {
            Shell.Current.GoToAsync("..");
            MessengerHelper.SendReloadDataMessage();
        }
        [RelayCommand]
        public async void AddInDataBase()
        {
            var confirm = await _alertService.ShowConfirmationAlert("", "Adicionar aos favoritos?", "Sim", "Não");
            if(confirm)
            {
                var AtraçãoBackup = Attraction;
                if (AtraçãoBackup != null)
                {
                    _repository.Add(Attraction);
                    foreach (var img in Attraction.Images)
                    {
                        _repository.AddImage(img);
                    }
                }
                Shell.Current.GoToAsync("..");
            }
        }
    }
}
