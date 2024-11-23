using Microsoft.Toolkit.Uwp.Notifications;
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
        static string userProfilePath = Environment.ExpandEnvironmentVariables("%userprofile%");
        public static FileSystemWatcher watcher = new FileSystemWatcher(Properties.Settings.Default.Directory == "" ? Path.Combine(userProfilePath, "Documents") : Properties.Settings.Default.Directory);

        public static void UpdateFilters()
        {
            NotifyFilters notifyFilters = 0;

            foreach (string filter in Properties.Settings.Default.Filters)
            {
                if (Enum.TryParse(filter, true, out NotifyFilters parsedFilter))
                {
                    notifyFilters |= parsedFilter;
                }
            }

            watcher.NotifyFilter = notifyFilters;
        }

        public static void Start()
        {
            watcher.EnableRaisingEvents = Properties.Settings.Default.Enabled;

            string FolderName = Properties.Settings.Default.Directory.Substring(Properties.Settings.Default.Directory.LastIndexOf("\\") + 1);

            new ToastContentBuilder()
                .AddText("Watchdog started")
                .AddText($"Directory: {FolderName}")
                .Show();
        }
    }
}
