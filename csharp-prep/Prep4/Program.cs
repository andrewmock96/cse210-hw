using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        
        int sum = 0;
        int inputNumber = -1;
        
        while (inputNumber != 0)
        {
            Console.Write("Enter number: ");
            string numberString = Console.ReadLine();
            inputNumber = int.Parse(numberString);
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }
        }
        //Find the sum
        foreach (int number in numbers)
        {
            sum += number;
        }
        //Find the average
        float average = ((float)sum) / numbers.Count;
        //Find the Max
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }


        //Display the sum, average, and max
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max number is: {max}");

    }
}