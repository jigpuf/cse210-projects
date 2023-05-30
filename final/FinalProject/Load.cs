public class Load
{   //This will load the requested file into the working file
    public void loadFile()
    {
                Console.WriteLine("What file would you like to load into your working file?");
                string loadFile = Console.ReadLine();
                //get lines from file and make array
                string[] lines = System.IO.File.ReadAllLines(loadFile);
                //put lines in working file Dont Append!!!
                    foreach (string line in lines){
                    using (StreamWriter outputFile = new StreamWriter("workingFile.txt",true))
                        {
                            outputFile.WriteLine($"{line}");
                        }         
                    }
    }
}