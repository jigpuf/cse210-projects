using System;

class Program
{
    static void Main(string[] args)
    {
        string choice  = "";
        //Make instance of the scripture
        Scripture chosen = new Scripture();
        //chooses one of several scriptures
        chosen.SetActiveScripture();
        //writes chosen scripture to an external file
        chosen.WriteActiveScripturetoFile();

        Display active = new Display();
        //sets the active scripture and displays it
        active.SetActiveText();
        //Loop for changing scripture
        Console.Write("\n\nType 'quit' to end the program. or anything else to continue.\n>");
            choice = Console.ReadLine();
        while(choice != "quit"){
            Console.Clear();
            active.ChangeActiveText();
            Console.Write("\n\nType 'quit' to end the program. or anything else to continue.\n>");
            choice = Console.ReadLine();
        }
        //quit program
        Quit message = new Quit();
            message.displayQuit();
    }
}