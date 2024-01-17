using ScreenshoterForm.ScreenShoterHelper;
using System.Timers;

namespace ScreenShoterHelper
{
    public static class ScreenShoter
    {
        static System.Timers.Timer CaptureScreenTimer = new System.Timers.Timer();
        public static async Task TakeScreenshot(string path, int quality)
        {
            using (var capture = new ScreenCapture())
            {
                await capture.CaptureScreens(path, quality);
            }
        }

        public static void StopScreenCapture()
        {
            CaptureScreenTimer.Stop();
        }

        public static void StartScreenCapture(int quality, int delayInMs)
        {
            PrepareOutputDirectory();

            if (CaptureScreenTimer.Enabled)
                CaptureScreenTimer.Stop();

            //CaptureScreenTimer.Elapsed += new  ElapsedEventHandler(CaptureScreenLogic(quality));
            CaptureScreenTimer.Elapsed += async (sender, e) =>
            {
                await CaptureScreenLogic(Path.Combine(Options.ScreenshotOutputDirectory, DateTime.Now.ToString("yyyy-MM-dd___HH-mm-ss-fffffff")), quality);
            };

            CaptureScreenTimer.Interval = delayInMs;
            CaptureScreenTimer.Start();
        }

        private static void PrepareOutputDirectory()
        {
            var dir = Path.Combine(Options.ScreenshotOutputDirectory);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

        }

        private static async Task CaptureScreenLogic(string filePath, int quality)
        {           
            await TakeScreenshot(filePath, quality);
        }

      

    }
}