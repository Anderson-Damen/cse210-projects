using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask user for first name
        Console.WriteLine("What is your first name?");
        string first_name = Console.ReadLine();

        //Ask user for last name
        Console.WriteLine("What is your last name?");
        string last_name = Console.ReadLine();
        
        //Print out the phrase.
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}