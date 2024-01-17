using System.Drawing.Imaging;

public class ScreenCapture : IDisposable
{
    private bool disposed = false;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
            disposed = true;
    }

    ~ScreenCapture()
    {
        Dispose(false);
    }

    public async Task CaptureScreens(string filePath, int quality)
    {
        try
        {
            Screen[] screens = Screen.AllScreens;

            int totalWidth = screens.Sum(screen => screen.Bounds.Width);
            int maxHeight = screens.Max(screen => screen.Bounds.Height);

            using (Bitmap screenshot = new Bitmap(totalWidth, maxHeight))
            {
                using (Graphics gfxScreenshot = Graphics.FromImage(screenshot))
                {
                    int xOffset = 0;

                    foreach (var screen in screens)
                    {
                        gfxScreenshot.CopyFromScreen(
                      screen.Bounds.Left,
                      screen.Bounds.Top,
                      xOffset,
                      0,
                      screen.Bounds.Size,
                      CopyPixelOperation.SourceCopy);

                        xOffset += screen.Bounds.Width;
                    }

                    EncoderParameters encoderParams = new EncoderParameters(1);
                    encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
                    ImageCodecInfo jpegCodecInfo = GetEncoderInfo(ImageFormat.Jpeg);

                    screenshot.Save($"{filePath}.jpg", jpegCodecInfo, encoderParams);
                }
            }
        }
        catch (Exception ex)
        {

        }
    }

    private static ImageCodecInfo GetEncoderInfo(ImageFormat format)
    {
        ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
        foreach (ImageCodecInfo codec in codecs)
        {
            if (codec.FormatID == format.Guid)
            {
                return codec;
            }
        }
        return null;
    }
}
