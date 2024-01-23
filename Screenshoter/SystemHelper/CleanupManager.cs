using ScreenshoterForm.ScreenShoterHelper;

namespace Screenshoter.SystemHelper
{
    public static class CleanupManager
    {
        static System.Timers.Timer CleanUpTimer = new System.Timers.Timer();

        public static async void StartCleanUpOldScreenshots(int DeleteOldFilesIfOlderThan)
        {
            if (CleanUpTimer.Enabled)
            {
                CleanUpTimer.Stop();
                CleanUpTimer.Start();
            }
            else
            {
                await CleanUpOldScreenshots(DeleteOldFilesIfOlderThan);

                CleanUpTimer.Interval = DeleteOldFilesIfOlderThan;
                CleanUpTimer.Elapsed += async (sender, e) =>
                {
                    await CleanUpOldScreenshots(DeleteOldFilesIfOlderThan);
                };

                CleanUpTimer.Start();
            }
        }

        public static void StopCleaningUp()
        {
            CleanUpTimer.Stop();
        }

        private static async Task CleanUpOldScreenshots(int DeleteOldFilesIfOlderThan)
        {
            var targetDirectory = Options.ScreenshotOutputDirectory;
            var cutoffDate = DateTime.Now.AddDays(DeleteOldFilesIfOlderThan);

            foreach (var file in Directory.EnumerateFiles(targetDirectory, "*", SearchOption.AllDirectories))
            {
                if (File.GetCreationTime(file) < cutoffDate)
                {
                    await Task.Run(() => File.Delete(file));
                }
            }

            foreach (var directory in Directory.EnumerateDirectories(targetDirectory, "*", SearchOption.AllDirectories))
            {
                if (Directory.GetCreationTime(directory) < cutoffDate && Directory.GetFiles(directory).Length == 0)
                {
                    await Task.Run(() => Directory.Delete(directory));
                }
            }             
        }
    }
}
