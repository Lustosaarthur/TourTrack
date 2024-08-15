using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTrack.Models;

namespace TourTrack.App.ViewModels.Details
{
    [QueryProperty(nameof(Accommodation), "accommodation")]
    public partial class DetailViewPageAccViewModel : ObservableObject
    {

        private Accommodation _accommodation;
        public Accommodation Accommodation 
        { get { return _accommodation; }
            set
            {
                if(_accommodation != value)
                {
                    _accommodation = value;
                    OnPropertyChanged();
                    if(_accommodation != null)
                    {
                        Task.Run(() => GetAmenities(_accommodation.Amenities));
                    }
                }
            }
        }
       

        [ObservableProperty]
        public List<string> _amenities;
        public DetailViewPageAccViewModel()
        {
            
        }

        [RelayCommand]
        public void GoBack()
        {
            Shell.Current.GoToAsync("..");
        }

        public void GetAmenities(string lista)
        {
            string listaIf = lista;
            string[] itens = listaIf.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> listaFinal = itens.Select(item => item.Trim()).ToList();

            Amenities = listaFinal;
        }
    }
}
