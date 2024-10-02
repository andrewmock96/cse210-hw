using System;

class Program
{
    static void Main(string[] args)
    {
        string userResponseString = "";
        int userResponse = 0;
        Console.WriteLine("Welcome to the Journal Program! \nPlease Select one of the following choices (just enter the number)");
        Console.Write("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit. \nWhat would you like to do? ");
        

        while (userResponse != 5)
        {
        userResponseString = Console.ReadLine();
        userResponse = int.Parse(userResponseString);
            if (userResponse == 1)
            {
                Console.WriteLine("you chose 1");
            }
            if (userResponse == 2)
            {
                Console.WriteLine("you chose 2");
            }
            if (userResponse == 3)
            {
                Console.WriteLine("you chose 3");
            }
            if (userResponse == 4)
            {
                Console.WriteLine("you chose 4");
            }
            else
            {
                Console.WriteLine("Choose a vaild entry.");
            }
        }
        Console.WriteLine("Thanks for using Develop02 Journal, GoodBye.");

    }
}