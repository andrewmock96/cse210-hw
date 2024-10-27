using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();

        //Goals
        goalManager.CreateGoal(new SimpleGoal("Prestige Master", "Reach 'Prestige Master' on Call of Duty Black Ops 6", 1000));
        goalManager.CreateGoal(new EternalGoal("Read scriptures", "Daily scripture reading", 150));
        goalManager.CreateGoal(new ChecklistGoal("Attend temple session", "Complete ten temple sesions", 500, 10, 5000));

        goalManager.DisplayPlayerInfo();

        goalManager.ListGoalNames();
        goalManager.ListGoalDetails();

        // Recorded events
        goalManager.RecordEvent("Prestige Master");// I haven't reached it yet, I just want to show that it works
        goalManager.RecordEvent("Read scriptures");
        goalManager.RecordEvent("Attend temple session");

        goalManager.DisplayPlayerInfo();

        // Save and load example
        string filePath = "goals.txt";
        goalManager.SaveGoals(filePath);
        goalManager.LoadGoals(filePath);

        goalManager.ListGoalDetails();
    }
}