using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class User32
    {
        public const string DllName = "User32.dll";

        [DllImport(DllName)]
        public static extern IntPtr FindWindow(
            string lpClassName, string lpWindowName);

        [DllImport(DllName)]
        public static extern IntPtr FindWindowEx(
            IntPtr parentHandle, IntPtr hWndChildAfter, string className, string windowTitle);



        [DllImport(DllName)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
    }
}
