using static System.Console;

namespace HotPepper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Title = "Hot Pepper!";
            SplashScreen.PrintSplashScreen();
            MainMenu.Start();
        }
    }
}