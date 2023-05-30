using System.IO; 

public class Display
{   
    public void getData(){
        string fileName="workingFile.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines){
                Console.WriteLine($"{line}");
            }
    }
}
