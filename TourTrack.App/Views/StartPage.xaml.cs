namespace TourTrack.App.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

    private void GoToShell(object sender, EventArgs e)
    {
        ((App)Application.Current).NavegateToShell();
    }
}