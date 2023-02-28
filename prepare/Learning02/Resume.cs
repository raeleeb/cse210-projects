using System;

public class Resume
{
    // Keeps track of the person's name and a list of their jobs.
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {
    }

    // Displays the resume, which shows the name first,
    // followed by displaying each one of the jobs.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    } 
}