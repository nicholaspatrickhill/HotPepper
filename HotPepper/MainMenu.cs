using static HotPepper.PepperRepo;
using static System.Console;


namespace HotPepper
{
    public class MainMenu
    {
        public static void Start()
        {
            var mainMenu = new MainMenu();
            RunMainMenu();
        }

        private static void RunMainMenu()
        {
            string prompt = "\n\t\tUse the UP and DOWN arrow keys to highlight a pepper and press enter.\n\n\n";
            string[] options =
            { 
                "\t\t\t\t\tBell Pepper",
                "\t\t\t\t\tCarolina Reaper",
                "\t\t\t\t\tCayenne",
                "\t\t\t\t\tFish Pepper",
                "\t\t\t\t\tGhost Pepper",
                "\t\t\t\t\tHabanero",
                "\t\t\t\t\tJalapeno",
                "\t\t\t\t\tLemon Drop",
                "\t\t\t\t\tPepperoncini",
                "\t\t\t\t\tSelf-Defense Pepper Spray",
                "\t\t\t\t\tPoblano",
                "\t\t\t\t\tScotch Bonnet",
                "\t\t\t\t\tSerrano",
                "\t\t\t\t\tTabasco",
                "\t\t\t\t\tTrinidad Scorpion",
                "\n\t\t\t\t\tExit"
            };
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
            Thread.Sleep(300);
            ForegroundColor = ConsoleColor.Red;
            Clear();
            Beep();
            WriteLine($"\n\n\n\n\n\n\n\t\tThe {pepperChoice.Name} has a scoville heat unit rating of {pepperChoice.SHU}.");
            Thread.Sleep(1000);
            ForegroundColor = ConsoleColor.Gray;
            WriteLine("\n\n\n\t\tPress any key to return and select another pepper.");
            ReadKey(true);
            Thread.Sleep(400);
            Start();
        }

        private static void ExitTheProgram()
        {
            Thread.Sleep(300);
            ForegroundColor = ConsoleColor.Gray;
            string prompt = "\n\n\n\n\n\n\n\t\t\t\tAre you sure you wish to exit the program?";
            string[] options = { "\n\t\t\t\tyes", "\t\t\t\tno" };
            
            Menu exitMenu = new Menu(prompt, options);
            int selectedIndex = exitMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Beep();
                    ForegroundColor= ConsoleColor.Gray;
                    Thread.Sleep(300);
                    WriteLine("\n\n\t\t\t\tStay spicy...\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Environment.Exit(0);
                    break;
                case 1:
                    Beep();
                    Thread.Sleep(300);
                    Start();
                    break;
            }
        }
    }
}