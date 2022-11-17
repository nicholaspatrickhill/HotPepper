using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HotPepper
{
    public class SplashScreen
    {
        public static void PrintSplashScreen()
        {
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("\n\n\n\n\n\n\n");
            WriteLine("\t\t\t\t\tWelcome to HotPepper...");
            Thread.Sleep(1000);
            WriteLine("\t\t\t\t\tGrab a glass of water...");
            Thread.Sleep(1000);
            WriteLine("\n\n\n\t\t\t\t\tPress any key to continue...");
            ReadKey(true);
            Clear();
            Thread.Sleep(500);
        }
    }
}
