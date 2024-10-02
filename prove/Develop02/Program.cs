using System;

class Program
{
    static void Main(string[] args)
    {
        string userResponseString = "";
        int userResponse = 0;
        
        Journal journal = new Journal();
        
        //Greethings
        Console.WriteLine("Welcome to the Journal Program! \nPlease Select one of the following choices (just enter the number)");

        //Loop with the User Interface for the Menu
        while (userResponse != 5)
        { 
        Console.Write("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit. \nWhat would you like to do? ");
        userResponseString = Console.ReadLine();
        userResponse = int.Parse(userResponseString);
           
            if (userResponse < 1 || userResponse > 5)
            {
                Console.WriteLine("Choose a vaild entry.");
            } 
            else
            {
                //Prompting for response and then saving the response
                if (userResponse == 1)
                {
                    journal.AddEntry();
                }
                //Displaying all saved responses
                if (userResponse == 2)
                {
                    journal.DisplayEntries();
                }
                //Load the saved responses from Journal.txt or any other file they are saved too
                if (userResponse == 3)
                {
                    journal.LoadEntriesFromFile();
                }
                //Save responses to file
                if (userResponse == 4)
                {
                    journal.SaveEntriesToFile();
                }
            }
        }
        Console.WriteLine("Thanks for using Develop02 Journal, GoodBye.");

    }
}

