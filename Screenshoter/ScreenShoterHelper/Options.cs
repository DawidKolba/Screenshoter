
namespace ScreenshoterForm.ScreenShoterHelper
{
    public static class Options
    {
        public static string ScreenshotOutputDirectory { get; set; } =
            $"{Path.Combine(Directory.GetCurrentDirectory(), "Screenshots", DateTime.Now.ToString("yyyy-MM-dd"))}";
    }
}
