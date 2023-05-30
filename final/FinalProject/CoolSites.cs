using System;

public class CoolSites : Url
{
    private string _genre = "";

    public string setGenre(){
        Console.WriteLine($"What Genre is this Website?");
        Console.Write(">");
        _genre = Console.ReadLine();
        return (_genre);
    }

    public void getData(string type){
        string url = setUrl(type);
        string title = setTitle(type);
        string year = setYear(type);
        string genre = setGenre();
        string entry = ($"{type}-{title} year:{year} url:{url} genre:{genre} ");
        Console.WriteLine(entry);
        string fileName = "workingFile.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName,true))
        {
            outputFile.WriteLine(entry);
        }
    }
}