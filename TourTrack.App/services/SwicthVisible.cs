using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTrack.App.services
{
    public static class SwicthVisible
    {
        public static void ToVisible(bool indicatorView1, bool indicatorView2)
        {
            indicatorView1 = true;
            indicatorView2 = false;
        }
        public static void ToInvisible(bool indicatorView1, bool indicatorView2)
        {
            indicatorView1 = false;
            indicatorView2 = true;
        }
    }
}
