using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your currect grade percentage? ");
        string userinput = Console.ReadLine();
        int grade = int.Parse(userinput);
        
        string letter = "q";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Your Grade is a {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats! You Passed!");
        }
        else if (grade < 70)
        {
            Console.WriteLine("Sorry you didn't pass, but try again, you got this!");
        }
    }
}