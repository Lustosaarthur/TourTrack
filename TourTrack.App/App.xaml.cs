using TourTrack.App.Views;

namespace TourTrack.App
{
    public partial class App : Application
    { 
        public static HttpClient HttpClient { get; private set; }
        public App()
        {
            InitializeComponent();

            string baseAddress;

           
            if (Device.RuntimePlatform == Device.Android)
            {
                if (IsEmulator())
                    baseAddress = "http://10.0.2.2:5033/";
                else 
                    baseAddress = "http://192.168.42.59:5033/";
            }
            else
                baseAddress = "http://localhost:5033/";

            MainPage = new AppShell();
            //MainPage = new ExplorePage();

#if DEBUG
            HttpClientHandler handler = services.HttpClientHandlerExtensions.GetInsecureHandler();
            HttpClient = new HttpClient(handler)
            {
                BaseAddress = new Uri(baseAddress)
            };
#else
HttpClient = new HttpClient
{
    BaseAddress = new Uri(baseAddress)
};
#endif

            bool IsEmulator()
            {
                if(DeviceInfo.DeviceType == DeviceType.Virtual)
                {
                    return true;
                }
                return false;
            }
        }

        public void NavegateToShell()
        {
            MainPage = new AppShell();
        }
    }
    
}
