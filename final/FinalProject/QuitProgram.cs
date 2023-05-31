using System;

public class QuitProgram
{
    public void Quit(){
        Console.WriteLine("Thanks for playing!!!");
        using (StreamWriter outputFile = new StreamWriter("workingFile.txt"))
        outputFile.Write("");   
    }
    public void Quit(string clear){
        using (StreamWriter outputFile = new StreamWriter("workingFile.txt"))
        outputFile.Write(""); 
    }
}