using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Exercise";
        _description = "This activity will help you relax by guding you through breathing in and out slowly. \nClear your mind and focus on your breathing.";
    }

    public override void PerformActivity()
    {
        StartActivity();
        for(int i = 0; i < _duration / 6; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            Console.WriteLine("Breath out...");
            ShowCountdown(3);
        }
        EndActivity();
    }
}