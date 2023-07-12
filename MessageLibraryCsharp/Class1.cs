using System;
using System.Runtime.InteropServices;

namespace MessageBoxDLL
{
    public class MessageBoxDLL
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        public static void ShowMessage(string message, string caption)
        {
            MessageBox(IntPtr.Zero, message, caption, 0);
        }
    }
}
