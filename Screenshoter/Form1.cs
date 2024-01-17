using ScreenShoterHelper;

namespace ScreenshoterForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            qualityTextbox.Text = "70";
            delayBetweenThePhotos.Text = "1000";
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
    }
}