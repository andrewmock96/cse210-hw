using System;

public class Resume
{
    public string _name;
    public list<Job>_jobs = new list<Job>();

    public void DisplayJobDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job in _jobs)
        {
            _jobs.DisplayJobDetails();
        } 
    }
}