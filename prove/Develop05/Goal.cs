using System;
using System.IO; 

public class Goal
{
//////////////////// Choice of type of goal

    protected string _choice = "";
////////////////////List goal data
    protected string _name = "";
    protected string _description ="";
    protected int _points = 0;
    protected int _timesToComplete = 1;
    protected int _timesCompleted = 0;
    protected bool _finished = false;
    protected int _bonus = 0;
///////////////////for entry into file

    protected string _entry ="";


///////////////////Questions to get info from user
    protected string _nameQuestion = "What do you want to name the Goal?";
    protected string _descriptionQuestion = "Write a description of the goal";
    protected string _pointsQuestion = "How many points is this goal worth?";
    protected string _timesToCompleteQuestion = "How many times to complete the goal?";

    protected string _bonusPointsQuestion = "How many points for finishing this goal?";

//////////////////////////getters-setters
    public void setChoice(string selection){
        _choice = selection;
    }
    public string SetName(){
        Console.WriteLine(_nameQuestion);
        return(Console.ReadLine());
    }
    public string SetDescription(){
        Console.WriteLine(_descriptionQuestion);
        return(Console.ReadLine());
    }
    public int SetPoints(){
        Console.WriteLine(_pointsQuestion);
        return(int.Parse(Console.ReadLine()));
    }
    public int SetTimesToComplete(){
        Console.WriteLine(_timesToCompleteQuestion);
        return(int.Parse(Console.ReadLine()));
    }
    public int SetTimesToComplete(int number){
        return(number);
    }
    public int SetTimesCompleted(int number){
        return(number);
    }
     public int SetBonus(int number){
        return(number);
    }
    public int SetBonus(){
        Console.WriteLine(_bonusPointsQuestion);
        return(int.Parse(Console.ReadLine()));
    }
 
    public bool SetFinished(bool state){
        return(state);
    }
    public string SetEntry(string entry){
        return entry;
    }
    public int GetTimesToComplete(int number){
        return(number);
    }
    public void GetName(){}
    public void GetDescription(){}
    public void AddToWorkingFile( string entry){
        string fileName = "workingFile.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName,true))
        {
            outputFile.WriteLine(entry);
        }
    }


//Handle Choice
    public void DisplayGoalTypes()
    {
        Console.Clear();
        Console.WriteLine("What type of goal will you create:"); 
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

             while(_choice != "1"&&_choice != "2"&&_choice != "3")
             {
                Console.Write("Select a choice from the menu:");
                 string selection = Console.ReadLine();
                switch(selection)
                {
                    case "1":
                        setChoice("1");
                        SimpleGoal simpleGoal = new SimpleGoal();
                        simpleGoal._name = simpleGoal.SetName();
                        simpleGoal._description = simpleGoal.SetDescription();
                        simpleGoal._points = simpleGoal.SetPoints();
                        simpleGoal._timesToComplete = simpleGoal.SetTimesToComplete(1);
                        simpleGoal._bonus = simpleGoal.SetBonus(0);
                        simpleGoal._timesCompleted = simpleGoal.SetTimesCompleted(0);
                        simpleGoal._finished = simpleGoal.SetFinished(false);
                        simpleGoal._entry = simpleGoal.SetEntry($"[{simpleGoal._timesCompleted}/1] {simpleGoal._name}: {simpleGoal._description}, {simpleGoal._points}, {simpleGoal._timesToComplete}, {simpleGoal._timesCompleted}, {simpleGoal._bonus}, {simpleGoal._finished}");
                        simpleGoal.AddToWorkingFile(simpleGoal._entry);
                        Console.WriteLine(simpleGoal._entry);
                        Console.WriteLine($"Hit enter to continue");
                        Console.ReadLine();
                        break;
                    case "2":
                        setChoice("2");
                        EternalGoal eternalGoal = new EternalGoal();
                        eternalGoal._name = eternalGoal.SetName();
                        eternalGoal._description = eternalGoal.SetDescription();
                        eternalGoal._points = eternalGoal.SetPoints();
                        eternalGoal._timesToComplete = eternalGoal.SetTimesToComplete(1000000);
                        eternalGoal._bonus = eternalGoal.SetBonus(0);
                        eternalGoal._timesCompleted = eternalGoal.SetTimesCompleted(0);
                        eternalGoal._finished = eternalGoal.SetFinished(false);
                        eternalGoal._entry = eternalGoal.SetEntry($"[{eternalGoal._timesCompleted}/Inf] {eternalGoal._name}: {eternalGoal._description}, {eternalGoal._points}, {eternalGoal._timesToComplete}, {eternalGoal._timesCompleted}, {eternalGoal._bonus}, {eternalGoal._finished}");
                        eternalGoal.AddToWorkingFile(eternalGoal._entry);
                        Console.WriteLine(eternalGoal._entry);
                        Console.WriteLine($"Hit enter to continue");
                        Console.ReadLine();
                        break;
                    case "3":
                        setChoice("3");
                        ChecklistGoal checklistGoal = new ChecklistGoal();
                        checklistGoal._name = checklistGoal.SetName();
                        checklistGoal._description = checklistGoal.SetDescription();
                        checklistGoal._points = checklistGoal.SetPoints();
                        checklistGoal._timesToComplete = checklistGoal.SetTimesToComplete();
                        checklistGoal._bonus = checklistGoal.SetBonus();
                        checklistGoal._timesCompleted = checklistGoal.SetTimesCompleted(0);
                        checklistGoal._finished = checklistGoal.SetFinished(false);
                        checklistGoal._entry = checklistGoal.SetEntry($"[{checklistGoal._timesCompleted}/{checklistGoal._timesToComplete}] {checklistGoal._name}: {checklistGoal._description}, {checklistGoal._points}, {checklistGoal._timesToComplete}, {checklistGoal._timesCompleted}, {checklistGoal._bonus}, {checklistGoal._finished}");
                        checklistGoal.AddToWorkingFile(checklistGoal._entry);
                        Console.WriteLine(checklistGoal._entry);
                        Console.WriteLine($"Hit enter to continue");
                        Console.ReadLine();
                        break;
/////////This handles bad entries of choice
                    default:
                        Console.WriteLine("Pick a real number!!!");
                        break;
                }
             }
    }
}