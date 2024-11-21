namespace FolderWatchdog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            exitToolStripMenuItem.Click += (s, e) => ExitApplication();
            settingsToolStripMenuItem.Click += (s, e) => ShowMainWindow();
            notifyIcon1.MouseClick += (s, e) => IconMouseClick(e);
            enabledToolStripMenuItem.CheckStateChanged += (s, e) => EnabledCheckStateChanged();
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


        private void ExitApplication()
        {
            allowExit = true;
            notifyIcon1.Visible = false;
            Application.Exit();
        }

        private void ShowMainWindow()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void IconMouseClick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowMainWindow();
            }
        }

        private void EnabledCheckStateChanged()
        {
            if (enabledToolStripMenuItem.Checked)
            {
                // Start the watchdog
            }
            else
            {
                // Stop the watchdog
            }
        }
    }
}
