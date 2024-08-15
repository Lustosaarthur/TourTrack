using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
    [QueryProperty(nameof(Attraction), "attraction")]
    public partial class DetailFavoritiesPageViewModel : ObservableObject
    {
        private readonly IAlertService _alertService;
        private IAttractionsDbRepository _repository;
        private TourTrackAppContext _appContext;
        [ObservableProperty]
        public Attraction _attraction;

        public DetailFavoritiesPageViewModel()
        {
            _appContext = new TourTrackAppContext();
            _repository = new AttractionsDbRepository(_appContext);
            _alertService = new AlertService();
        }
        [RelayCommand]
        public void GoBack()
        {
            Shell.Current.GoToAsync("..");
        }
        [RelayCommand]
        public async Task DeleteAsync()
        {
            bool confirm = await _alertService.ShowConfirmationAlert("Confirmação", "Você deseja excluir?", "Sim", "Não");
            if (confirm)
            {
                _repository.Delete(_attraction);
                await _alertService.ShowAlert("Sucesso", "Atração excluída com sucesso.", "OK");
                MessengerHelper.SendReloadDataMessage();
            }
            Shell.Current.GoToAsync("..");
        }
    }
}
