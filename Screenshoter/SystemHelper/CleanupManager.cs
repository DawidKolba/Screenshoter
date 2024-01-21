using ScreenshoterForm.ScreenShoterHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screenshoter.SystemHelper
{
    public static class CleanupManager
    {
        public static void CleanUpOldScreenshots(int DeleteOldFilesIfOlderThan)
        {
            var targetDirectory = Options.ScreenshotOutputDirectory;
            var cutoffDate = DateTime.Now.AddDays(DeleteOldFilesIfOlderThan);

            foreach (var file in Directory.EnumerateFiles(targetDirectory, "*", SearchOption.AllDirectories))
            {
                if (File.GetCreationTime(file) < cutoffDate)
                {
                    File.Delete(file);
                }
            }

            foreach (var directory in Directory.EnumerateDirectories(targetDirectory, "*", SearchOption.AllDirectories))
            {
                if (Directory.GetCreationTime(directory) < cutoffDate && Directory.GetFiles(directory).Length == 0)
                {
                    Directory.Delete(directory);
                }
            }
        }
    }
}
