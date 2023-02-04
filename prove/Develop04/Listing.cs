using System;

class Listing : Activity
{
    private string _listingSummary = "This activity will help you reflect on good things by doing Listing stuff.";
    private int _listNumber = 0;
    private int _promptSelector;
    private string[] _listingPrompt = {
        "--- Good food you ate this week ---",
        "--- Good books you have read ---",
        "--- Funny Jokes you know ---",
    };
    public void GetListingSummary()
    {
        Console.WriteLine(_listingSummary);
    }
    public void ListingActivity(){
        Console.WriteLine("List as many responses as you can to the following prompt");
        Random rnd = new Random();
        int promptSelector = rnd.Next(0, 2);
        Console.WriteLine(_listingPrompt[promptSelector]);
        int pauseTime = 0;
        Console.Write("You ar about to begin");
        while(pauseTime < 5){
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            pauseTime += 1;
        }
        Console.WriteLine("");
        Console.WriteLine("GOOOOOO!");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        while(DateTime.Now  < futureTime){
            Console.Write(">");
            Console.ReadLine();
            _listNumber += 1;
        }
        Console.WriteLine($"You listed {_listNumber} items!");
    }

}