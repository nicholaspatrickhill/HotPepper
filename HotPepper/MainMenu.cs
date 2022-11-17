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
                    if (peppers.ContainsKey("carolinaReaper"))
                    {
                        Pepper pepperChoice = peppers["carolinaReaper"];
                        PrintPepper(pepperChoice);
                    }
                    break;
                case 2:
                    if (peppers.ContainsKey("cayenne"))
                    {
                        Pepper pepperChoice = peppers["cayenne"];
                        PrintPepper(pepperChoice);
                    }
                    break;
                case 3:
                    if (peppers.ContainsKey("fishPepper"))
                    {
                        Pepper pepperChoice = peppers["fishPepper"];
                        PrintPepper(pepperChoice);
                    }
                    break;
                case 4:
                    if (peppers.ContainsKey("ghostPepper"))
                    {
                        Pepper pepperChoice = peppers["ghostPepper"];
                        PrintPepper(pepperChoice);
                    }
                    break;
                case 5:
                    if (peppers.ContainsKey("habanero"))
                    {
                        Pepper pepperChoice = peppers["habanero"];
                        PrintPepper(pepperChoice);
                    }
                    break;
                case 6:
                    if (peppers.ContainsKey("jalapeno"))
                    {
                        Pepper pepperChoice = peppers["jalapeno"];
                        PrintPepper(pepperChoice);
                    }
                    break;
                case 7:
                    if (peppers.ContainsKey("lemonDrop"))
                    {
                        Pepper pepperChoice = peppers["lemonDrop"];
                        PrintPepper(pepperChoice);
                    }
                    break;
                case 8:
                    if (peppers.ContainsKey("pepperoncini"))
                    {
                        Pepper pepperChoice = peppers["pepperoncini"];
                        PrintPepper(pepperChoice);
                    }
                    break;
                case 9:
                    if (peppers.ContainsKey("pepperSpray"))
                    {
                        Pepper pepperChoice = peppers["pepperSpray"];
                        PrintPepper(pepperChoice);
                    }
                    break;
                case 10:
                    if (peppers.ContainsKey("poblano"))
                    {
                        Pepper pepperChoice = peppers["poblano"];
                        PrintPepper(pepperChoice);
                    }
                    break;
                case 11:
                    if (peppers.ContainsKey("scotchBonnet"))
                    {
                        Pepper pepperChoice = peppers["scotchBonnet"];
                        PrintPepper(pepperChoice);
                    }
                    break;
                case 12:
                    if (peppers.ContainsKey("serrano"))
                    {
                        Pepper pepperChoice = peppers["serrano"];
                        PrintPepper(pepperChoice);
                    }
                    break;
                case 13:
                    if (peppers.ContainsKey("tabasco"))
                    {
                        Pepper pepperChoice = peppers["tabasco"];
                        PrintPepper(pepperChoice);
                    }
                    break;
                case 14:
                    if (peppers.ContainsKey("trinidadScorpion"))
                    {
                        Pepper pepperChoice = peppers["trinidadScorpion"];
                        PrintPepper(pepperChoice);
                    }
                    break;
                case 15:
                    ExitTheProgram();
                    break;
            }
        }

        private static void PrintPepper(Pepper pepperChoice)
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine($"The {pepperChoice.Name} has a scoville heat unit rating of {pepperChoice.SHU}.");
            WriteLine();
            WriteLine("Press any key to return to return and select another pepper.");
            ReadKey(true);
            Start();
        }

        private static void ExitTheProgram()
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("Are you sure you wish to exit the program?");
            WriteLine("Type \"y\" and press enter to exit or type \"n\" and press enter to return to the Main Menu.");

            ForegroundColor = ConsoleColor.Red;
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