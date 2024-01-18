using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);
        
        string loop = "yes";
        
        while (loop == "yes")
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            int numberGuess = int.Parse(userGuess);
        
            if (numberGuess > magicNumber)
            {
              Console.WriteLine("Lower");
              loop = "yes";
            }
            else if (numberGuess < magicNumber)
            {
                Console.WriteLine("Higher");
                loop = "yes";
            }
            else if (numberGuess == magicNumber)
            {
                Console.Write("You guessed it!");
                loop = "no";
            }
        }
    }
}