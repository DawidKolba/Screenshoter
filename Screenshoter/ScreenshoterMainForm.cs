using Screenshoter.SystemHelper;
using ScreenshoterForm.ScreenShoterHelper;
using ScreenShoterHelper;
using System.Configuration;

namespace ScreenshoterForm
{
    public partial class ScreenshoterMainForm : Form
    {
        private ShortcutManager _shortcutManager;
        private NotifyIcon trayIcon;
        private ContextMenuStrip trayMenu;

        public ScreenshoterMainForm()
        {
            InitializeComponent();
            _shortcutManager = new ShortcutManager(this.Handle);
            deleteOldFilesPanel.Enabled = false; deleteOldFilesPanel.Visible = false;
            TryRegisterShortcut(Keys.F11, StartSeriesCapture);
            TryRegisterShortcut(Keys.Control | Keys.H, ToggleMainWindow);
            TryRegisterShortcut(Keys.F8, StartAutomaticCapture);
            trayMenu = new ContextMenuStrip();
            trayMenu.Items.Add("Open", null, this.RestoreFromTray);
            trayMenu.Items.Add("Close", null, this.ExitApplication);
            trayIcon = new NotifyIcon()
            {
                Icon = new Icon("appicon.ico"),
                ContextMenuStrip = trayMenu,
                Visible = false
            };

            trayIcon.MouseDoubleClick += TrayIcon_MouseDoubleClick;
            this.Resize += MainForm_Resize;
            LoadConfig();
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            MainForm_Resize();
        }

        public void LoadConfig()
        {
            qualityTextbox.Text = ConfigurationManager.AppSettings["Quality"];
            delayBetweenThePhotos.Text = ConfigurationManager.AppSettings["DelayBetweenPhotos"];
            CountOfImagesTb.Text = ConfigurationManager.AppSettings["CountOfImages"];
            deleteOldFilesIfOlderThan.Text = ConfigurationManager.AppSettings["DeleteOldFilesIfOlderThan"];
        }

        public void SaveConfig()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["Quality"].Value = qualityTextbox.Text;
            config.AppSettings.Settings["DelayBetweenPhotos"].Value = delayBetweenThePhotos.Text;
            config.AppSettings.Settings["CountOfImages"].Value = CountOfImagesTb.Text;
            config.AppSettings.Settings["DeleteOldFilesIfOlderThan"].Value = deleteOldFilesIfOlderThan.Text;

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void MainForm_Resize()
        {
            if (WindowState != FormWindowState.Minimized)
            {
                this.Hide();
                trayIcon.Visible = true;
                ShowInTaskbar = false;
            }
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RestoreFromTray(sender, e);
        }

        private void RestoreFromTray(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            trayIcon.Visible = false;
            ShowInTaskbar = true;
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit();
        }

        private async void StartSeriesCapture()
        {
            ToggleMainWindow();
            int countOfImages = int.Parse(CountOfImagesTb.Text);
            int delayBetweenPhotos = int.Parse(delayBetweenThePhotos.Text);
            int quality = int.Parse(qualityTextbox.Text);

            await ScreenShoter.TakeMultipleScreenshots(countOfImages, delayBetweenPhotos, quality);
        }

        private void ToggleMainWindow()
        {
            MainForm_Resize();
        }

        private void StartAutomaticCapture()
        {
            ToggleMainWindow();
        }

        private void TryRegisterShortcut(Keys keys, Action action)
        {
            try
            {
                _shortcutManager.RegisterShortcut(keys, action);
            }
            catch (Exception ex)
            {
                _shortcutManager = new ShortcutManager(this.Handle);
                _shortcutManager.RegisterShortcut(Keys.F12, StartSeriesCapture);
                _shortcutManager.RegisterShortcut(Keys.Control | Keys.H, ToggleMainWindow);
                _shortcutManager.RegisterShortcut(Keys.F8, StartAutomaticCapture);
            }
        }

        private async void takeSingleScreenshot_Click(object sender, EventArgs e)
        {
            await ScreenShoter.TakeScreenshot(
                   Path.Combine
                       (Options.ScreenshotOutputDirectory, $"TestScreenshot_{DateTime.Now.ToString("yyyy-MM-dd___HH-mm-ss-ffffff")}"),
                        int.Parse(qualityTextbox.Text)
                       );
        }

        private void startScreenshoting_Click(object sender, EventArgs e)
        {
            ScreenShoter.StartScreenCapture(
                int.Parse(qualityTextbox.Text),
                int.Parse(delayBetweenThePhotos.Text)
                );
        }

        private void moreInfoBtn_Click(object sender, EventArgs e)
        {
            string messageBoxText = "Screenshoter Application - How It Works\n\n" +
                        "Single Shot Mode:\n" +
                        "Quickly capture a screenshot by pressing F11. Ideal for instant screen captures without any hassle.\n\n" +
                        "Manual Series Mode:\n" +
                        "Initiate a series of timed screenshots with F11. Set the interval in the app settings to capture everything from fast-paced sequences to slow, detailed processes.\n\n" +
                        "Automatic Mode:\n" +
                        "The app automatically takes screenshots at predetermined intervals. Enable this mode, and let Screenshoter handle the rest while you focus on other tasks.\n\n" +
                        "Show/Hide Main Window:\n" +
                        "Use Ctrl + H to minimize to tray icon the app's main window. To restore use double click on app's tray icon.\nThis feature allows for easy access to the app when you need it and keeps it out of the way when you don’t.";

            MessageBox.Show(messageBoxText, "Application Help", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            MainForm_Resize(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (removeoldPhotosCb.Checked)
            {
                try
                {
                    deleteOldFilesPanel.Enabled = true;
                    deleteOldFilesPanel.Visible = true;
                    CleanupManager.StartCleanUpOldScreenshots(int.Parse(deleteOldFilesIfOlderThan.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
            }
            else
            {
                deleteOldFilesPanel.Enabled = false;
                deleteOldFilesPanel.Visible = false;
                CleanupManager.StopCleaningUp();
            }
        }

        private async void manualSeriesScreenshotBtn_Click(object sender, EventArgs e)
        {
            int countOfImages = int.Parse(CountOfImagesTb.Text);
            int delayBetweenPhotos = int.Parse(delayBetweenThePhotos.Text);
            int quality = int.Parse(qualityTextbox.Text);

            await ScreenShoter.TakeMultipleScreenshots(countOfImages, delayBetweenPhotos, quality);
        }

        private void saveCfg_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }
    }
}