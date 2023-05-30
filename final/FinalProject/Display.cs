using System.IO; 

public class Display
{   
    public void getData(){
        Console.Clear();
        string fileName="workingFile.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines){
                Console.WriteLine($"{line}");
            }
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

    }
}