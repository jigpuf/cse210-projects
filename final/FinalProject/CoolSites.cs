using System;

public class CoolSites : Website
{
    private string _genre = "";

    public string SetGenre(){
        Console.WriteLine($"What Genre is this Website?");
        Console.Write(">");
        _genre = Console.ReadLine();
        return (_genre);
    }

    public void GetData(string type){
        string url = SetUrl(type);
        string title = SetTitle(type);
        string year = SetYear(type);
        string genre = SetGenre();
        string entry = ($"{type}-{title} year:{year} url:{url} genre:{genre} ");
        Console.WriteLine(entry);
        string fileName = "workingFile.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName,true))
        {
            outputFile.WriteLine(entry);
        }
    }
}