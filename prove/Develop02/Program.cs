using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

class Program
{
    
    static void Main(string[] args)
    {
        string userChoice = "1";

        while (userChoice != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine(" 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");

            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Write");
                    break;
                case "2":
                    Console.WriteLine("Display");
                    break;
                case "3":
                    Console.WriteLine("load");
                    break;
                case "4":
                    Console.WriteLine("Save");
                    break;
                case "5":
                    Console.WriteLine("Display");
                    break;
                default:
                    Console.WriteLine("Please enter a number between 1 and 5");
                    break;
            }
        }
    }
}