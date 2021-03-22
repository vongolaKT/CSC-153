using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HogwartsConsole
{
    // I did not write this, wanted a solution because my ascii art was too large to fit on the default console : Thanks John Wu!
    // I figured since this only has anything to do with console it could go in the consoleui

    // FROM HERE:
    // https://stackoverflow.com/questions/22053112/maximizing-console-window-c-sharp/22053200

    // It seems to get info from the system then changes the value of the console process' window state which in windows is a 0 for hide, 3 for max, 6 for min, and 9 for restore the original size.
    public class ConsoleView
    {
        [DllImport("user32.dll")]

        public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);

        public static void Maximize()
        {
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3); //SW_MAXIMIZE = 3
        }
    }
}
