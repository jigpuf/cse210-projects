using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int choice = -1;
        while (choice != 0 ){
            Console.WriteLine("Enter number:");
            choice = int.Parse(Console.ReadLine());
            if (choice != 0){
                numbers.Add(choice);
            }
        }
        float sum = 0;
        foreach (int number in numbers){
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The Average is: {sum/numbers.Count}");
        int largest = -1;
        foreach  (int number in numbers){
            if (number > largest){
                largest = number;
            }
        }
        Console.WriteLine($"The Largest number is: {largest}");

    }
}