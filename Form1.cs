using System.Diagnostics;
using System.Drawing.Text;

namespace FolderWatchdog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            enabledToolStripMenuItem.Checked = Properties.Settings.Default.Enabled;
            enabledCheckBox.Checked = Properties.Settings.Default.Enabled;
            watchFilesCheckBox.Checked = Properties.Settings.Default.WatchFiles;
            watchSubdirectoriesCheckBox.Checked = Properties.Settings.Default.WatchSubdirectories;

            directoryTextBox.Text = Properties.Settings.Default.Directory;

            void SetFilterCheckBox(CheckBox checkBox)
            {
                checkBox.CheckedChanged -= new EventHandler(ToggleFilter);
                checkBox.Checked = Properties.Settings.Default.Filters.Contains(checkBox.Name);
                checkBox.CheckedChanged += new EventHandler(ToggleFilter);
            }

            CheckBox[] checkBoxes = [ fileNamesFilterCheckBox, directoryNamesFilterCheckBox, attributesFilterCheckBox, sizeFilterCheckBox, writeFilterCheckBox, accessFilterCheckBox, creationFilterCheckBox, securityFilterCheckBox ];

            Array.ForEach(checkBoxes, checkBox => {
                SetFilterCheckBox(checkBox);
            });
        }

        private bool allowExit = false;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!allowExit)
            {
                e.Cancel = true;
                this.Hide();
                this.ShowInTaskbar = false;
            }
            allowExit = false;
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            allowExit = true;
            notifyIcon1.Visible = false;
            Application.Exit();
        }

        private void ShowMainWindow(object? sender, EventArgs? e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
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
            if (enabledToolStripMenuItem.Checked)
            {
                Debug.WriteLine("Start the watchdog");
            }
            else
            {
                Debug.WriteLine("Stop the watchdog");
            }
            Properties.Settings.Default.Save();
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

        private List<CheckBox> filtersToToggle = new List<CheckBox>();

        private void ToggleFilter(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (filtersToToggle.Contains(checkBox))
            {
                filtersToToggle.Remove(checkBox);
            }
            else
            {
                filtersToToggle.Add(checkBox);
            }
        }

        private void SaveSettings(object sender, EventArgs e)
        {
            filtersToToggle.ForEach(checkBox =>
            {
                string filter = checkBox.Name;
                if (Properties.Settings.Default.Filters.Contains(filter))
                {
                    Properties.Settings.Default.Filters.Remove(filter);
                }
                else
                {
                    Properties.Settings.Default.Filters.Add(filter);
                }
            });
            filtersToToggle.Clear();

            enabledToolStripMenuItem.Checked = enabledCheckBox.Checked;
            Properties.Settings.Default.Enabled = enabledToolStripMenuItem.Checked;
            Properties.Settings.Default.WatchFiles = watchFilesCheckBox.Checked;
            Properties.Settings.Default.WatchSubdirectories = watchSubdirectoriesCheckBox.Checked;
            Properties.Settings.Default.Directory = directoryTextBox.Text;

            Properties.Settings.Default.Save();
            this.Hide();
            this.ShowInTaskbar = false;
        }

        private void CloseSettings(object sender, EventArgs e)
        {
            filtersToToggle.ForEach(checkBox =>
            {
                checkBox.CheckedChanged -= new EventHandler(ToggleFilter);
                checkBox.Checked = !checkBox.Checked;
                checkBox.CheckedChanged += new EventHandler(ToggleFilter);
            });

            filtersToToggle.Clear();

            this.Hide();
            this.ShowInTaskbar = false;
        }
    }
}
