using System;

class Assignment
{
    protected string _studentName;
    protected string _topic;
    
    public Assignment(string name, string topic){
        _studentName = name;
        _topic = topic;
    }

    public string GetStudentName(){
        return _studentName;
    }

    public string GetTopic(){
        return _topic;
    }

    public string GetSummary(){
        return ($"{_studentName} - {_topic}");
    }
}