using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> journalEntries;
    public List<string> prompts;

    public Journal()
    {
        journalEntries = new List<Entry>();
        prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?", 
            "What was the best part of my day?", 
            "How did I see the hand of the Lord in my life today?", 
            "What was the strongest emotion I felt today?", 
            "If I had one thing I could do overy today, what would it be?",
            "What are you most grateful for today?",
            "What is something you learned recently?",
            "Reflect on a memory that makes you happy?",
            "What did you fail at, or fell short of today?"
        };
    }

    public void AddEntry()
    {
        string prompt = GetRandomPrompt();

        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your Response: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry(prompt, response);

        journalEntries.Add(newEntry);

        Console.WriteLine("Your entry has been saved.");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    public void DisplayEntries()
    {
        Console.WriteLine("Journal Entries: ");
        if (journalEntries.Count == 0)
        {
            Console.WriteLine("No entries available.");
        }
        else
        {
            foreach (Entry entry in journalEntries)
            {
                Console.WriteLine(entry.ToString());
            }
        }
    }

    public void SaveEntriesToFile()
    {
        Console.Write("Enter the filename to save the journal entries: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in journalEntries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }

        Console.WriteLine($"Journal entries have been saved to {filename}.");
    }

    public void LoadEntriesFromFile()
{
    Console.Write("Enter the filename to load the journal entries from: ");
    string filename = Console.ReadLine();

    if (!File.Exists(filename))
    {
        Console.WriteLine("File not found.");
        return;
    }

    journalEntries.Clear();

    foreach (string line in File.ReadLines(filename))
    {
        string[] parts = line.Split('|');
        if (parts.Length == 3)
        {
            DateTime entryDate;
            if (DateTime.TryParse(parts[0], out entryDate))
            {
                journalEntries.Add(new Entry(parts[1], parts[2])
                {
                    Date = entryDate 
                });
            }
        }
    }

    Console.WriteLine($"Journal entries have been loaded from {filename}.");
}
}

