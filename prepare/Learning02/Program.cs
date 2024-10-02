using System;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new Job();
        job1.company = "Microsoft";
        job1.jobTitle = "Software Engineer";
        job1.startYear = 2019;
        job1.endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;
    }
}