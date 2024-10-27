using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start() => Console.WriteLine("Goal Manager started.");

    public void DisplayPlayerInfo() => Console.WriteLine($"Total Score: {_score}");

    public void ListGoalNames()
    {
        Console.WriteLine("Goal Names:");
        foreach (var goal in _goals)
            Console.WriteLine(goal.GetStringRepresentation());
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
            Console.WriteLine(goal.GetDetailsString());
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
        Console.WriteLine($"Goal '{goal.GetStringRepresentation()}' has been added.");
    }

    public void RecordEvent(string goalName)
    {
        var goal = _goals.Find(g => g.GetStringRepresentation().Contains(goalName));
        if (goal == null) Console.WriteLine("Goal not found.");
        else
        {
            goal.RecordEvent();
            if (goal.IsComplete())
                _score += goal.Points;
            Console.WriteLine($"Event recorded for '{goalName}'. Current score: {_score}");
        }
    }

    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
                writer.WriteLine($"{goal.GetType().Name}|{goal.GetStringRepresentation()}");
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        using (StreamReader reader = new StreamReader(filePath))
        {
            _score = int.Parse(reader.ReadLine());
            _goals.Clear();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                string goalType = parts[0];
                string goalData = parts[1];

                if (goalType == "SimpleGoal")
                    _goals.Add(new SimpleGoal(goalData, "Description", 100));  // Basic placeholder values
                else if (goalType == "EternalGoal")
                    _goals.Add(new EternalGoal(goalData, "Description", 50));   // Basic placeholder values
                else if (goalType == "ChecklistGoal")
                    _goals.Add(new ChecklistGoal(goalData, "Description", 20, 5, 200));  // Placeholder
            }
        }
        Console.WriteLine("Goals loaded.");
    }
}