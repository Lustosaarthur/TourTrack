using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTrack.App.services.Messages
{
    public class MessengerHelper
    {
        public static event Action<ReloadDataMessage> ReloadDataRequested;
        public static void SendReloadDataMessage()
        {
            ReloadDataRequested?.Invoke(new ReloadDataMessage());
        }
    }
}
