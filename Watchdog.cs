using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderWatchdog
{
    public static class Watchdog
    {
        public static void Start()
        {
            Debug.WriteLine("Watchdog started");
        }

        public static void Stop()
        {
            Debug.WriteLine("Watchdog stopped");
        }
    }
}
