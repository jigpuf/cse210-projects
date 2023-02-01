using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment first = new MathAssignment("Keller", "Math", "7.3", "5-9");
        Console.WriteLine(first.GetSummary());
        Console.WriteLine(first.GetHomeworkList());
        WritingAssignment next = new WritingAssignment("Kman", "writing", "A New Hope by Hope Goodman");
        Console.WriteLine(next.GetSummary());
        Console.WriteLine(next.GetWritingInformation());
    }
}