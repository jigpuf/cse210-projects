using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade?");
        int grade = int.Parse(Console.ReadLine());
        if (grade >= 90){
            Console.WriteLine("You got an A");
        }
        else if (grade >=80){
            Console.WriteLine("You got an B");
        }
        else if (grade >=70){
            Console.WriteLine("You got an C");
        }
        else if (grade >=80){
            Console.WriteLine("You got an D");
        }
        else{
            Console.WriteLine("You got an F");
        }
    }
}