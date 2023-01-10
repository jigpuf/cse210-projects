public class Job
{
    //blueprint for new jobs being created
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;
    //This is the method that displays all the attributes
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
