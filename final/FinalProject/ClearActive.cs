using System;

public class ClearActive
{
    public void clear(){
        using (StreamWriter outputFile = new StreamWriter("workingFile.txt"))
        outputFile.Write("");   
    }
}