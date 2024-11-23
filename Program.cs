using FolderWatchdog.Properties;
using System.Diagnostics;

namespace FolderWatchdog
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            form1.WindowState = FormWindowState.Minimized;
            form1.ShowInTaskbar = false;
            Application.Run(form1);
            Application.Run(new Form1());

            Properties.Settings.Default.Reset();
        }
    }
}