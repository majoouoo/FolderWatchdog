using Microsoft.Toolkit.Uwp.Notifications;
using System.Diagnostics;
using System.Drawing.Text;

namespace FolderWatchdog
{
    public partial class Form1 : Form
    {
        private CheckBox[] eventCheckBoxes = [];
        public Form1()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            enabledToolStripMenuItem.Checked = Properties.Settings.Default.Enabled;
            enabledCheckBox.Checked = Properties.Settings.Default.Enabled;
            watchSubdirectoriesCheckBox.Checked = Properties.Settings.Default.WatchSubdirectories;

            string userProfilePath = Environment.ExpandEnvironmentVariables("%userprofile%");
            directoryTextBox.Text = Properties.Settings.Default.Directory == "" ? Path.Combine(userProfilePath, "Documents") : Properties.Settings.Default.Directory;
            Properties.Settings.Default.Directory = Properties.Settings.Default.Directory == "" ? Path.Combine(userProfilePath, "Documents") : Properties.Settings.Default.Directory;

            eventCheckBoxes = [onChangedEventCheckBox, onCreatedEventCheckBox, onDeletedEventCheckBox, onRenamedEventCheckBox];

            foreach (CheckBox checkBox in eventCheckBoxes)
            {
                string tag = checkBox.Tag.ToString();
                checkBox.Checked = (bool)Properties.Settings.Default[tag];
            }
        }

        private bool allowExit = false;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!allowExit)
            {
                e.Cancel = true;
                CloseSettings(null, null);
            }
            allowExit = false;
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            allowExit = true;
            notifyIcon1.Visible = false;
            ToastNotificationManagerCompat.Uninstall();
            Application.Exit();
        }

        public void ShowMainWindow(object? sender, EventArgs? e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            enabledCheckBox.Checked = Properties.Settings.Default.Enabled;
        }

        private void IconMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowMainWindow(null, null);
            }
        }

        private void ToggleEnabledAndSave(object sender, EventArgs e)
        {
            enabledCheckBox.Checked = enabledToolStripMenuItem.Checked;
            Properties.Settings.Default.Enabled = enabledToolStripMenuItem.Checked;
            if (enabledToolStripMenuItem.Checked)
            {
                Watchdog.Start();
            }
            else
            {
                Watchdog.watcher.EnableRaisingEvents = false;
            }
            Properties.Settings.Default.Save();
        }

        public void DisableWatchdog()
        {
            enabledToolStripMenuItem.Checked = false;
        }

        private void BrowseDirectories(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = directoryTextBox.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                directoryTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ToggleFilter(object sender, EventArgs e)
        {
            watchSubdirectoriesCheckBox.Checked = !watchSubdirectoriesCheckBox.Checked;
        }

        private void SaveSettings(object sender, EventArgs e)
        {
            Properties.Settings.Default.WatchSubdirectories = watchSubdirectoriesCheckBox.Checked;

            string userProfilePath = Environment.ExpandEnvironmentVariables("%userprofile%");
            Properties.Settings.Default.Directory = directoryTextBox.Text == "" ? Properties.Settings.Default.Directory : directoryTextBox.Text;
            directoryTextBox.Text = Properties.Settings.Default.Directory;

            Watchdog.watcher.Path = Properties.Settings.Default.Directory;
            Watchdog.watcher.IncludeSubdirectories = Properties.Settings.Default.WatchSubdirectories;

            if (enabledCheckBox.Checked && (enabledToolStripMenuItem.Checked == enabledCheckBox.Checked))
            {
                Watchdog.Start();
            }

            enabledToolStripMenuItem.Checked = enabledCheckBox.Checked;
            Properties.Settings.Default.Enabled = enabledToolStripMenuItem.Checked;

            foreach (CheckBox checkBox in eventCheckBoxes)
            {
                string tag = checkBox.Tag.ToString();
                Properties.Settings.Default[tag] = checkBox.Checked;
            }
            Watchdog.UpdateEventSettings();

            Properties.Settings.Default.Save();
            this.Hide();
            this.ShowInTaskbar = false;
        }

        private void CloseSettings(object? sender, EventArgs? e)
        {
            this.Hide();
            this.ShowInTaskbar = false;

            enabledCheckBox.Checked = Properties.Settings.Default.Enabled;
            watchSubdirectoriesCheckBox.Checked = Properties.Settings.Default.WatchSubdirectories;
            directoryTextBox.Text = Properties.Settings.Default.Directory;

            foreach (CheckBox checkBox in eventCheckBoxes)
            {
                string tag = checkBox.Tag.ToString();
                checkBox.Checked = (bool)Properties.Settings.Default[tag];
            }
        }
    }
}
