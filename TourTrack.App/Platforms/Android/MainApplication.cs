using Android.App;
using Android.Content.Res;
using Android.Runtime;

namespace TourTrack.App
{
#if DEBUG                                   // connect to local service on the
    [Application(UsesCleartextTraffic = true)]  // emulator's host for debugging,
#else                                       // access via http://10.0.2.2
    [Application]                               
#endif
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
            {
                if (view is Entry)
                {
                    // Remove underline
                    handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Transparent);

                    // Change placeholder text color
                    handler.PlatformView.SetHintTextColor(ColorStateList.ValueOf(Android.Graphics.Color.Gray));
                }
            });
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
