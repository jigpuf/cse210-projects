using System;

class Breathing : Activity
{
    public void GetBreathingSummary()
    {
        Console.WriteLine("This activity will help you by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }
    public void BreathingActivity(){
        int cycle = 0;
         while(cycle < _time){
            Console.Write("\nBreathe in...");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            Console.WriteLine("");

            Console.Write("Breathe out...");
            Console.Write("6");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            Console.WriteLine("");
            cycle += 10;
        }

    }
}

