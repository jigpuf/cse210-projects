public class Resume
{   
    //The attribute that lives at this level of the class
    public string _name;

    // Make sure to initialize your list to a new List before you use it.
    //This creates a new list per instance using the attribute variable _jobs and the Jobs Class
    public List<Job> _jobs = new List<Job>();

    //This method displays the name attribute, and a string for jobs
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop,  The jobs have to be entered from the instances in main
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.Display();
        }
    }
}