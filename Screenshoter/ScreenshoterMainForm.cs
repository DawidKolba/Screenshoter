using Screenshoter.SystemHelper;
using ScreenshoterForm.ScreenShoterHelper;
using ScreenShoterHelper;
using System.Configuration;
using System.Runtime.InteropServices;

namespace ScreenshoterForm
{
    public partial class ScreenshoterMainForm : Form
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int HOTKEY_F11_ID = 1;
        private const int HOTKEY_CTRL_H_ID = 2;
        private const int HOTKEY_F8_ID = 3;

        public ScreenshoterMainForm()
        {
            InitializeComponent();
            deleteOldFilesPanel.Enabled = false; deleteOldFilesPanel.Visible = false;

            RegisterShortcuts();
            LoadConfig();
        }

        private void RegisterShortcuts()
        {
            RegisterHotKey(this.Handle, HOTKEY_F11_ID, 0, (uint)Keys.F11);
            RegisterHotKey(this.Handle, HOTKEY_CTRL_H_ID, 2 /* Ctrl */, (uint)Keys.H);
            RegisterHotKey(this.Handle, HOTKEY_F8_ID, 0, (uint)Keys.F8);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312) // WM_HOTKEY
            {
                switch (m.WParam.ToInt32())
                {
                    case HOTKEY_F11_ID:
                        StartSeriesCapture();
                        break;
                    case HOTKEY_CTRL_H_ID:
                        ToggleMainWindow();
                        break;
                    case HOTKEY_F8_ID:
                        StartAutomaticCapture();
                        break;
                }
            }
            base.WndProc(ref m);
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
                this.Opacity = 0.0f;
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.Opacity = 1.0f;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void StartSeriesCapture()
        {
            await ExecuteSeriesCapture();
        }

        private void ToggleMainWindow()
        {
            MainForm_Resize();
        }

        private void StartAutomaticCapture()
        {
            ToggleMainWindow();
        }

        private async void takeSingleScreenshot_Click(object sender, EventArgs e)
        {
            int quality = int.Parse(qualityTextbox.Text);
            await ScreenShoter.TakeMultipleScreenshots(1, 0, quality);
        }

        private void startScreenshoting_Click(object sender, EventArgs e)
        {
            ScreenShoter.StartScreenCapture(
                int.Parse(qualityTextbox.Text),
                int.Parse(delayBetweenThePhotos.Text)
                );
        }

        private async Task ExecuteSeriesCapture()
        {
            try
            {
                int countOfImages = int.Parse(CountOfImagesTb.Text);
                int delayBetweenPhotos = int.Parse(delayBetweenThePhotos.Text);
                int quality = int.Parse(qualityTextbox.Text);

                await ScreenShoter.TakeMultipleScreenshots(countOfImages, delayBetweenPhotos, quality);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid value\n{ex}");
            }
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

        private void DeleteOldPhotos_CheckedChanged(object sender, EventArgs e)
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
            await ExecuteSeriesCapture();
        }

        private void saveCfg_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }
    }
}