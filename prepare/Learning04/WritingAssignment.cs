using System;

class WritingAssignment : Assignment
{
    private string _title;
    

    //constructor uses 2 variables from base and 1 specific to this class
    public WritingAssignment(string name, string topic, string title): base(name, topic){
        _title = title;
    }

    public string GetWritingInformation(){
        return ($"{_studentName} - {_topic} \n{_title}");
    }
}