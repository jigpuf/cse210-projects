using System;

public class Website
{

    public string SetUrl(string type){
        Console.WriteLine($"What is the URL of the {type}?");
        Console.Write(">");
        string url = Console.ReadLine();
        return(url);
    }
    public string SetTitle(string type){
        Console.WriteLine($"What is the Title of the {type}?");
        Console.Write(">");
        string title = Console.ReadLine();
        return(title);
    }
    public string SetYear(string type){
        Console.WriteLine($"What year was the {type} made?");
        Console.Write(">");
        string year = Console.ReadLine();
        return(year);
    }
}