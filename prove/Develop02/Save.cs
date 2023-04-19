using System.IO; 


public class Save
{   
    public void getFileName()
    {
                Console.WriteLine("What is the name of the file we will save to?");
                string saveFileName = Console.ReadLine();
                string workingFile="workingFile.txt";
                    string[] lines = System.IO.File.ReadAllLines(workingFile);
                    foreach (string line in lines){
                        using (StreamWriter outputFile = new StreamWriter(saveFileName,true))
                                {
                                    outputFile.WriteLine($"{line}");
                                }            
                    }
    }
}

       