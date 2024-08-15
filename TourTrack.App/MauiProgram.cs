using Microsoft.Extensions.Logging;
using TourTrack.App.Repositories;
using TourTrack.App.services.Alerts;
using TourTrack.Models.Persistence;
using CommunityToolkit.Maui;

namespace TourTrack.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("JustNote-Regular.ttf", "JustNoteRegular");
                fonts.AddFont("Urw-Antiquanar-bold.otf", "AntiquanarBold");
                fonts.AddFont("TT-Firs-Neue-Bold.ttf", "TtFirsNeueBold");
                fonts.AddFont("tanseek-modern-pro-arabic-light.ttf", "ArabicLight");
                fonts.AddFont("tanseek-modern-pro-arabic-medium.ttf", "ArabicMedium");
            }).UseMauiCommunityToolkit();
#if DEBUG
            builder.Logging.AddDebug();
            builder.Services.AddSingleton<TourTrackAppContext>();
            builder.Services.AddSingleton<IAttractionsDbRepository, AttractionsDbRepository>();
            builder.Services.AddSingleton<IAlertService, AlertService>();
#endif
            return builder.Build();
        }
    }
}