using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while(choice != 5){
            Console.WriteLine("What is your first name?");
            choice = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Thanks for playing!");
    }
}