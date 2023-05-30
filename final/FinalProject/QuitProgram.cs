using System;

public class QuitProgram
{
    public void quit(){
        Console.WriteLine("Thanks for playing!!!");
        using (StreamWriter outputFile = new StreamWriter("workingFile.txt"))
        outputFile.Write("");   
    }
}