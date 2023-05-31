using System;

public class Standup : Website
{
    private string _subject = "";
    public string SetSubject(){
        Console.WriteLine($"What subject is covered in this Standup?");
        Console.Write(">");
        _subject = Console.ReadLine();
        return (_subject);
    }

    public void GetData(string type){
        string url = SetUrl(type);
        string title = SetTitle(type);
        string year = SetYear(type);
        string subject = SetSubject();
        string entry = ($"{type}-{title} year:{year} url:{url} subject:{subject} ");
        Console.WriteLine(entry);
        string fileName = "workingFile.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName,true))
        {
            outputFile.WriteLine(entry);
        }
    }
}