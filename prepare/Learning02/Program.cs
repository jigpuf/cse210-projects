using System;

class Program
{
    static void Main(string[] args)
    {
        //Make the instances within the main loop job1,2,myResume are all instances
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        //This adds the job instances to the list that is part of the resume class within the instance of myresume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        //calls the display method from the myresume instance of the resume class
        myResume.Display();
    }
}