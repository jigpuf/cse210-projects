using System;

public class Talks : Url
{
    private string _subject = "";
    public string setSubject(){
        Console.WriteLine($"What subject is covered in this talk?");
        Console.Write(">");
        _subject = Console.ReadLine();
        return (_subject);
    }

    public void getData(string type){
        string url = setUrl(type);
        string title = setTitle(type);
        string year = setYear(type);
        string subject = setSubject();
        string entry = ($"{type}-{title}  year:{year} url:{url} subject:{subject}");
        Console.WriteLine(entry);
        string fileName = "workingFile.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName,true))
        {
            outputFile.WriteLine(entry);
        }
    }
}