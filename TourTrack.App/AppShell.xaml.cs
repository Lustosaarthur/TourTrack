using TourTrack.App.Views.Details;

namespace TourTrack.App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("MainPage/detail", typeof(DetailViewPage));
            Routing.RegisterRoute("MainPage/detailacc", typeof(DetailViewPageAcc));
            Routing.RegisterRoute("FavoritiesPage/detail", typeof(DetailFavoritiesPage));
            Routing.RegisterRoute("ExplorePage/detail", typeof(DetailViewPage));
        }
    }
}
