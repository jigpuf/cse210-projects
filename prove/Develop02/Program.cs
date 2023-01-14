using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while(choice != 6){
                Options instance = new Options();
                instance.displayOptions();
                choice = int.Parse(Console.ReadLine());
            if(choice == 1){
                Write message = new Write();
                message.displayPrompt();
                message.getEntry();
            }
            else if(choice ==2){
                Display message = new Display();
                message.getData();
            }
            else if(choice ==3){
                Load message = new Load();
                message.displayLoad();               
            }
            else if(choice ==4){
                Save message = new Save();
                message.getFileName();                
            }
            else if(choice ==5){
                Clear clear = new Clear();
                clear.clearWorkingFile();                
            }
            else if(choice ==6){
                Quit message = new Quit();
                message.displayQuit();
            }
        }
    }
}
