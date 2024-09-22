using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);

        DisplayResults(userName, squareNumber);

        //First Function - Welcome
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        //Second Function - Ask for name
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        //Third Function - Ask for fav number
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        //Fourth Function - Square fav number
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        //Fifth Function - Display results
        static void DisplayResults(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
} 