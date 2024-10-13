using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureReference reference = new ScriptureReference("Proverbs", 3, 5, 6);
        string text = "5 Trust in the Lord with all thine heart; and lean not unto thine own understanding. \n6 In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("\nPress Enter to hide part of the scripture, or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }

        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nAll words are hidden. \nGoodbye!");
    }
}