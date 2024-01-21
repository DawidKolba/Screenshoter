using ScreenShoterHelper;

namespace ScreenshoterForm
{
    public partial class Form1 : Form
    {
        private ShortcutManager _shortcutManager;
        private NotifyIcon trayIcon;
        private ContextMenuStrip trayMenu;

        public Form1()
        {
            InitializeComponent();
            qualityTextbox.Text = "70";
            delayBetweenThePhotos.Text = "1000";
            _shortcutManager = new ShortcutManager(this.Handle);
            panel1.Enabled = false; panel1.Visible = false;
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
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            MainForm_Resize();
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
            trayIcon.Visible = false; // Ukrycie ikony w zasobniku
            Application.Exit(); // Zamkniêcie aplikacji
        }
        private void StartSeriesCapture()
        {
            // Logika dla F12
        }

        private void ToggleMainWindow()
        {
            MainForm_Resize();
        }

        private void StartAutomaticCapture()
        {
            // Logika dla F8
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

        private async void button1_Click(object sender, EventArgs e)
        {
            await ScreenShoter.TakeScreenshot(
                   Path.Combine
                       (Directory.GetCurrentDirectory(), $"TestScreenshot_{DateTime.Now.ToString("yyyy-MM-dd___HH-mm-ss-ffffff")}"),
                        int.Parse(qualityTextbox.Text)
                       );
        }

        private void button2_Click(object sender, EventArgs e)
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
            if (checkBox1.Checked) { panel1.Enabled = true; panel1.Visible = true; }
           else { panel1.Enabled = false; panel1.Visible = false; }
        }
    }
}