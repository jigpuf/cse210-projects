public class Clear
{   //This just chooses a random prompt and displays it
int index;
string prompt;
    // The date is added to the entry
    public void clearWorkingFile(){
        string fileName = "workingFile.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("");
        }
    }
}