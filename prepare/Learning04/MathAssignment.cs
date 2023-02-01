using System;

class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
    

    //constructor uses 2 variables from base and 2 specific to this class
    public MathAssignment(string name, string topic, string section, string problems): base(name, topic){
        _textbookSection = section;
        _problems = problems;
    }

    public string GetTextbookSection(){
        return _textbookSection;
    }

    public string GetProblems(){
        return _problems;
    }

    public string GetHomeworkList(){
        return ($"{_studentName} - {_topic} \nSection {_textbookSection} Problems {_problems}");
    }
}