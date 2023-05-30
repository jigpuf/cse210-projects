using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "0";
        int totalPoints = 0;
        int UpdateTotalPoints(){
            string[] lines = System.IO.File.ReadAllLines("workingFile.txt");
            Console.WriteLine(lines);
            int number = 1;
            return(number);
        }
        while(choice != "6"){
            Console.Clear();
            totalPoints = UpdateTotalPoints();
            Console.WriteLine($"You have {totalPoints} points"); 

            Console.WriteLine("Menu Options:"); 
            Console.WriteLine("  1. Create new goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("Select a choice from the menu:");
            choice = Console.ReadLine();
            switch(choice){
                    case "1":
                        Goal goal = new Goal();
                        goal.DisplayGoalTypes();
                        break;
                    case "2":
                       Display display = new Display();
                        display.getData();
                        Console.WriteLine($"Hit enter to continue");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("What is the name of the file we will save to?");
                        string saveFileName = Console.ReadLine();
                        string workingFile="workingFile.txt";
                        //clear file
                        using (StreamWriter outputFile = new StreamWriter(saveFileName))
                        outputFile.Write("");
                        //add to file
                        string[] lines = System.IO.File.ReadAllLines(workingFile);
                        foreach (string line in lines){
                            using (StreamWriter outputFile = new StreamWriter(saveFileName,true))
                                {
                                    outputFile.WriteLine($"{line}");
                                }            
                        }
                       break;
                    case "4":
                        Console.WriteLine("What file would you like to load into your working file?");
                        string loadFile = Console.ReadLine();
                        //get lines from file and make array
                        string[] list = System.IO.File.ReadAllLines(loadFile);
                        //clear working file
                        using (StreamWriter outputFile = new StreamWriter("workingFile.txt"))
                        outputFile.Write("");
                        //put lines in working file Dont Append!!!
                            foreach (string line in list){
                        using (StreamWriter outputFile = new StreamWriter("workingFile.txt",true))
                            {
                                outputFile.WriteLine($"{line}");
                            }         
                        }
                        break;
                    case "5":
                        Console.WriteLine("What file would you like to load into your working file?");

                       break;
                    case "6":
                        Console.WriteLine("Thanks for playing!!!");
                        using (StreamWriter outputFile = new StreamWriter("workingFile.txt"))
                        outputFile.Write("");
                       break;
                    default:
                        Console.WriteLine("Pick a real number!!!");
                        break;
            }
        }
    
    }
}