using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    { 
        List<int> numbers = new List<int>();

        int numberInput = -1;
        while (numberInput != 0)
        {
            Console.Write("Enter a number (Enter 0 to quit): ");

            string userInput = Console.ReadLine();
            numberInput = int.Parse(userInput);

            if (numberInput != 0)
            {
                numbers.Add(numberInput);
            }
        }

        int total = 0;
        foreach(int number in  numbers)
        {
            total += number;
        }
        Console.WriteLine($"The sum is: {total}");

        float average = ((float)total) / numbers.Count;
        Console.WriteLine ($"The average is: {average}");

        int largestNum = numbers[0];

        foreach(int number in numbers)
        {
            if (number > largestNum)
            {
                largestNum = number;
            }
        }
        Console.WriteLine($"The Largest number is: {largestNum}");
    }
}
