public class Write
{   //This just chooses a random prompt and displays it
int index;
string prompt;
    public void displayPrompt(){
        string[] prompts = {"Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?",    
        "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?", 
        "What super Power would you choose?"
        };
        Random rnd = new Random();
        index =  rnd.Next(5);
        prompt = prompts[index];
        Console.WriteLine($"{prompt}");
        Console.Write(">");

    }
    //This creates the working file where the entry will be saved until it moves to the journal
    // The date is added to the entry
    public void getEntry(){
        string fileName = "workingFile.txt";
        string entry = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
        using (StreamWriter outputFile = new StreamWriter(fileName,true))
        {
            outputFile.WriteLine($"{dateText} {prompt} {entry}");
        }
    }
}