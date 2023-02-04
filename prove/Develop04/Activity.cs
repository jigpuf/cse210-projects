using System;

class Activity
{
    protected string _endingMessage = "\nWell Done!!";
    protected int _time;
    public void SpinnerPause(){

    }

    public void Start(){
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _time = int.Parse(Console.ReadLine());
        Console.Clear();
        int pauseTime = 0;
        Console.Write("Get ready...");
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
    }
    public void GetStartingMessage(string choice){
        Console.Clear();
        Console.WriteLine( $"Welcome to the {choice} Activity\n");
    }
    public void GetEndingMessage(string choice){
        Console.WriteLine(_endingMessage);
        Console.WriteLine($"You have completed another {_time} seconds of the {choice} Activity");
        int pauseTime = 0;
        while(pauseTime < 5){
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            pauseTime += 1;
        }
                Console.Write("");
    }
  
}