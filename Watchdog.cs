using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

namespace FolderWatchdog
{
    public static class Watchdog
    {
        static string userProfilePath = Environment.ExpandEnvironmentVariables("%userprofile%");
        public static FileSystemWatcher watcher = new FileSystemWatcher(Properties.Settings.Default.Directory == "" ? Path.Combine(userProfilePath, "Documents") : Properties.Settings.Default.Directory);

        private static Form1? formInstance;
        public static void Initialize(Form1 form1)
        {
            UpdateEventSettings();
            ToastNotificationManagerCompat.OnActivated += ToastActivated;
            formInstance = form1;

            Watchdog.watcher.IncludeSubdirectories = Properties.Settings.Default.WatchSubdirectories;
            Watchdog.watcher.Filter = Properties.Settings.Default.Filter;
        }

        public static void Start()
        {
            watcher.EnableRaisingEvents = Properties.Settings.Default.Enabled;

            string FolderName = Properties.Settings.Default.Directory.Substring(Properties.Settings.Default.Directory.LastIndexOf("\\") + 1);

            new ToastContentBuilder()
                .AddText("Watchdog started")
                .AddText($"Directory: {FolderName}")
                .AddButton(new ToastButton()
                    .SetContent("Settings")
                    .AddArgument("action", "showMainWindow"))
                .AddButton(new ToastButton()
                    .SetContent("Disable")
                    .AddArgument("action", "disableWatchdog"))
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
                .AddButton(new ToastButton()
                    .SetContent("Settings")
                    .AddArgument("action", "showMainWindow"))
                .AddButton(new ToastButton()
                    .SetContent("Disable")
                    .AddArgument("action", "disableWatchdog"))
                .Show();
        }

        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            new ToastContentBuilder()
                .AddText("File created")
                .AddText($"File: {e.Name}")
                .AddButton(new ToastButton()
                    .SetContent("Settings")
                    .AddArgument("action", "showMainWindow"))
                .AddButton(new ToastButton()
                    .SetContent("Disable")
                    .AddArgument("action", "disableWatchdog"))
                .Show();
        }

        private static void OnDeleted(object sender, FileSystemEventArgs e)
        {
            new ToastContentBuilder()
                .AddText("File deleted")
                .AddText($"File: {e.Name}")
                .AddButton(new ToastButton()
                    .SetContent("Settings")
                    .AddArgument("action", "showMainWindow"))
                .AddButton(new ToastButton()
                    .SetContent("Disable")
                    .AddArgument("action", "disableWatchdog"))
                .Show();
        }

        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            new ToastContentBuilder()
                .AddText("File renamed")
                .AddText($"Old name: {e.OldName}")
                .AddText($"New name: {e.Name}")
                .AddButton(new ToastButton()
                    .SetContent("Settings")
                    .AddArgument("action", "showMainWindow"))
                .AddButton(new ToastButton()
                    .SetContent("Disable")
                    .AddArgument("action", "disableWatchdog"))
                .Show();
        }

        private static void ToastActivated(ToastNotificationActivatedEventArgsCompat args)
        {
            ToastArguments arguments = ToastArguments.Parse(args.Argument);

            if (arguments.Contains("action"))
            {
                if (arguments["action"] == "showMainWindow" || arguments["action"] == null)
                {
                    formInstance.Invoke(delegate
                    {
                        formInstance.ShowMainWindow(null, null);
                    });
                }
                else if (arguments["action"] == "disableWatchdog")
                {
                    formInstance.Invoke(new Action(formInstance.DisableWatchdog));
                }
            }
            else
            {
                formInstance.Invoke(delegate
                {
                    formInstance.ShowMainWindow(null, null);
                });
            }
        }
    }
}
