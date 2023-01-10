using System;

class Program
{
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName(){
        Console.WriteLine("Please enter your name:");
        return(Console.ReadLine());
    }
    static int PromptUserNumber(){
        Console.WriteLine("Please enter your favorite number:");
        return(int.Parse(Console.ReadLine()));
    }
    static int SquareNumber(int number){
        return(number*number);
    }
    static void DisplayResult(string name,int number, int square){
        Console.WriteLine($"{name}, the quare of {number} is {square}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, number, square);
    }
}