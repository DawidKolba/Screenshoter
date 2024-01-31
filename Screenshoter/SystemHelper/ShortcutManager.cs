using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Logging;
using Screenshoter.SystemHelper;

public class ShortcutManager
{
    [DllImport("user32.dll")]
    private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

    [DllImport("user32.dll")]
    private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

    private IntPtr _windowHandle;
    private int _currentId;

    private static readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

    public ShortcutManager(IntPtr windowHandle)
    {
        _windowHandle = windowHandle;
        _currentId = 0;
    }

    public void RegisterShortcut(Keys key, Action action, int id)
    {
        uint modifiers = 0;

        if ((key & Keys.Control) == Keys.Control)
        {
            modifiers |= 0x0002; // MOD_CONTROL
            key &= ~Keys.Control;
        }

        if ((key & Keys.Alt) == Keys.Alt)
        {
            modifiers |= 0x0001; // MOD_ALT
            key &= ~Keys.Alt;
        }

        if ((key & Keys.Shift) == Keys.Shift)
        {
            modifiers |= 0x0004; // MOD_SHIFT
            key &= ~Keys.Shift;
        }

        _currentId++;
        if (!RegisterHotKey(_windowHandle, id, modifiers, (uint)key))
        {
            string errorMessage = $"Cannot register provided shortcut: {key} with modifiers: {modifiers}!";
            _logger.Error(errorMessage);
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        Application.AddMessageFilter(new MessageFilter(_windowHandle, id, action));
    }

    public void Dispose()
    {
        for (int i = 1; i <= _currentId; i++)
        {
            UnregisterHotKey(_windowHandle, i);
        }
    }
}
