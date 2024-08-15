using TourTrack.App.ViewModels;

namespace TourTrack.App.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private void Entry_Focused(object sender, FocusEventArgs e)
    {
        var viewModel = BindingContext as MainPageViewModel;
        viewModel?.OnEntryFocused();
    }

    private void Entry_Unfocused(object sender, FocusEventArgs e)
    {
        var viewModel = BindingContext as MainPageViewModel;
        viewModel?.OnEntryUnfocused();
    }
}


