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
        public static void Initialize()
        {
            UpdateEventSettings();
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

        public static void UpdateEventSettings()
        {
            watcher.Changed -= OnChanged;
            watcher.Created -= OnCreated;
            watcher.Deleted -= OnDeleted;
            watcher.Renamed -= OnRenamed;
            if (Properties.Settings.Default.OnChanged)
                watcher.Changed += OnChanged;
            if (Properties.Settings.Default.OnCreated)
                watcher.Created += OnCreated;
            if (Properties.Settings.Default.OnDeleted)
                watcher.Deleted += OnDeleted;
            if (Properties.Settings.Default.OnRenamed)
                watcher.Renamed += OnRenamed;
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            new ToastContentBuilder()
                .AddText("File changed")
                .AddText($"File: {e.Name}")
                .Show();
        }

        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            new ToastContentBuilder()
                .AddText("File created")
                .AddText($"File: {e.Name}")
                .Show();
        }

        private static void OnDeleted(object sender, FileSystemEventArgs e)
        {
            new ToastContentBuilder()
                .AddText("File deleted")
                .AddText($"File: {e.Name}")
                .Show();
        }

        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            new ToastContentBuilder()
                .AddText("File renamed")
                .AddText($"Old name: {e.OldName}")
                .AddText($"New name: {e.Name}")
                .Show();
        }
    }
}
