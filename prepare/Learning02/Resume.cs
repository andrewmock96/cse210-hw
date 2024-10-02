using System;

public class Resume
{
    public string _name;
    public list<Job>_jobs = new list<Job>();

    public void DisplayJobDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (job in _jobs)
        {
            _jobs.DisplayJobDetails();
        } 
    }
}