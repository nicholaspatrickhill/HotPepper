using static HotPepper.PepperRepo;
using static System.Console;


namespace HotPepper
{
    public class MainMenu
    {
        public static void Start()
        {
            var mainMenu = new MainMenu();
            mainMenu.RunMainMenu();
        }

        private void RunMainMenu()
        {
            string prompt = "Use the UP and DOWN arrow keys to highlight the pepper you wish to review and press enter.\n";
            string[] options = { "Bell Pepper", "Carolina Reaper", "Cayenne", "Fish Pepper", "Ghost Pepper", "Habanero",
            "Jalapeno", "Lemon Drop", "Pepperoncini", "Pepper Spray", "Poblano", "Scotch Bonnet", "Serrano", "Tabasco", 
            "Trinidad Scorpion", "\nExit"};
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    if (peppers.ContainsKey("bellPepper"))
                    {
                        Pepper pepperChoice = peppers["bellPepper"];
                        PrintPepper(pepperChoice);
                    }
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    ExitTheProgram();
                    break;
            }
        }

        private static void PrintPepper(Pepper pepperChoice)
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine($"The {pepperChoice.Name} has a scoville rating of {pepperChoice.SHU}.");
            WriteLine();
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            Start();
        }

        private static void ExitTheProgram()
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("Are you sure you wish to exit the program?");
            WriteLine("Type \"y\" and press enter to exit or type \"n\" and press enter to return to the Main Menu.");

            ForegroundColor = ConsoleColor.Cyan;
            string input = ReadLine() ?? String.Empty;

            switch (input.ToLower())
            {
                case "y":
                    ForegroundColor = ConsoleColor.White;
                    Environment.Exit(0);
                    break;
                case "n":
                    Start();
                    break;
                default:
                    ForegroundColor = ConsoleColor.White;
                    WriteLine();
                    WriteLine("Invalid Command. Please try again.");
                    ExitTheProgram();
                    break;
            }
        }
    }
}