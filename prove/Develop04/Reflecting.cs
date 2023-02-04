using System;

class Reflecting : Activity
{   private string[] _prompt = {
    "--- Which came first? Chicken or the Egg? ---",
    "--- Why eat for free when you can eat for 2? ---",
    "--- What's the matter? ---",
    "--- What ever happened to Sam Beckett? ---",
    "--- How close to the cliff edge could you drive? ---",
    "--- What's up? ---"
};
     public void GetReflectingSummary()
    {
        Console.WriteLine("This activity will help you by doing reflecting stuff.");
    }
    public void ReflectingActivity()
    {
        Console.WriteLine("Consider the following prompt:");
        Random rnd = new Random();
        int promptChoice = rnd.Next(0, 5);
        Console.WriteLine(_prompt[promptChoice]);
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("How would you answer that question?");
        int reflectTime = 0;
        while(reflectTime < _time){
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            reflectTime += 1;
        }
                Console.Write("");
    }
}