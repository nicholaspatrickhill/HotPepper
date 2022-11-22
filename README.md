**HotPepper** is a console application that displays the Scoville Heat Unit rating of various hot peppers.

### NOTES
**PROGRAM START:** The program begins by calling the PrintSplashScreen method.
PrintSplashScreen uses WriteLine and Thread.Sleep to introduce the user to the application.
It then uses ReadKey to request user response to bring them to the main menu.
Upon user response, the Start method is called from the MainMenu class.

**MAIN MENU:** RunMainMenu generates an arrow-key driven menu in the console.
The menu's functionality and design are established in the Menu class.
RunMainMenu prompts the user to move the cursor with the up and down arrow keys on their keyboard to select a pepper and press enter.
The user's input executes cases in a switch that call methods to display the Scoville Heat Unit rating of their selected pepper.

**DICTIONARIES & OBJECTS:** The Pepper class establishes the properties that are shared by the various hot peppers.
The hot peppers are instantiated as objects within the peppers dictionary in the PepperRepo class.
The peppers' values are assigned in the dictionary.
Those values are returned in the main menu as a concatenated string on a new screen by the PrintPepper method.

**EXITING THE PROGRAM:** Selecting "Exit" calls the ExitTheProgram method.
ExitTheProgram prompts the user to confirm that they wish to terminate the program by selecting "yes" or "no."
ExitTheProgram initializes a new instance of the menu class.
The user's input executes cases in a switch.
Selecting "yes" calls an exit method to terminate the program.
Selecting "no" calls the Start method to return the user to the home menu.

**DESIGN ELEMENTS** The application uses tabs and newlines in the WriteLine methods for clarity and aesthetics.
Thread.Sleep is called by the splash screen and each time a new screen is generated for a dynamic user experience.
Console.Beep is used to provide the user with audible feedback each time that they make a selection.

#### INSTRUCTIONS
Press any key on the splash screen to begin the program.
In the main menu, use the UP and DOWN arrow keys to highlight the pepper you wish to review and press enter.
The Scoville Heat Unit rating will be displayed on the next screen.
When you are finished reviewing that pepper's SHU rating, press enter to return to the menu.
Select Exit to terminate the program when you are finished.

