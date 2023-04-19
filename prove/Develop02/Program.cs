using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int choice = 0;
        while(choice != 6){
                Console.WriteLine("\n1) Write to Working File");
                Console.WriteLine("2) Display Working File");
                Console.WriteLine("3) Load Another File");
                Console.WriteLine("4) Save to Another File");
                Console.WriteLine("5) Clear Working File");
                Console.WriteLine("6) Quit");
                Console.WriteLine("7) Clear Console");
                Console.Write("Choose one: ");
                choice = int.Parse(Console.ReadLine());
                switch(choice){
                    case 1:
                        Write message = new Write();
                        message.displayPrompt();
                        message.getEntry();
                        break;
                    case 2:
                        Display display = new Display();
                        display.getData();
                        break;
                    case 3:
                        Load load = new Load();
                        load.displayLoad();
                       break;
                    case 4:
                    Save save = new Save();
                        save.getFileName();
                        break;
                    case 5:
                        using (StreamWriter outputFile = new StreamWriter("workingFile.txt"))
                        outputFile.WriteLine("");
                       break;
                    case 6:
                        Console.WriteLine("Thanks for playing!");
                       break;
                    case 7:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Pick a real number!!!");
                        break;
                }
        }
    }
}
