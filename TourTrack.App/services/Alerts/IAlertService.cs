
namespace TourTrack.App.services.Alerts
{
    public interface IAlertService
    {
        Task ShowAlert(string title, string message, string cancel);
        Task<bool> ShowConfirmationAlert(string title, string message, string accept, string cancel);
    }
}