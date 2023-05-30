using System;

public class Choice
{
    private string _choice = "0";
    public void displayChoices(){
         while(_choice != "6"){
            Console.WriteLine("Menu Options:"); 
            Console.WriteLine("  1. Add to active list");
            Console.WriteLine("  2. Show active list");
            Console.WriteLine("  3. Save list to file");
            Console.WriteLine("  4. Load list from file");
            Console.WriteLine("  5. Clear Active List");
            Console.WriteLine("  6. Quit");
            Console.WriteLine("  7. Clear Console");


            Console.Write("Select a choice from the menu:");
            _choice = Console.ReadLine();
            switch(_choice){
                    case "1":
                        MediaType media = new MediaType();
                        media.displayChoices();
                        break;
                     case "2":
                        Display display = new Display();
                        display.getData();
                        break;
                    case "3":
                        Save save = new Save();
                        save.save();
                       break;
                    case "4":
                        Load load = new Load();
                        load.loadFile();
                        break;
                    case "5":
                        QuitProgram clear = new QuitProgram();
                        clear.quit("clear");
                        break;
                    case "6":
                        QuitProgram quit = new QuitProgram();
                        quit.quit();
                        break;
                    case "7":
                        Console.Clear();
                        break;   
                    default:
                        Console.WriteLine("Pick a real number!!!");
                        break;
            }
        }
    }
}