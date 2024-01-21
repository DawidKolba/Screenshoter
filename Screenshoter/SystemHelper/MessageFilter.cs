namespace Screenshoter.SystemHelper
{
    class MessageFilter : IMessageFilter
    {
        private IntPtr _windowHandle;
        private int _id;
        private Action _action;

        public MessageFilter(IntPtr hWnd, int id, Action action)
        {
            _windowHandle = hWnd;
            _id = id;
            _action = action;
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == _id)
            {
                _action.Invoke();
                return true;
            }
            return false;
        }
    }
}