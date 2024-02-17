using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

class Program
{
    
    static void Main(string[] args)
    {
        Journal journal = new Journal();
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
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();

                    //Entry
                    Entry entry = new Entry();
                    entry._prompt = prompt;
                    entry._response = response;
                    entry._entryDate = DateTime.Now;

                    //Journal
                    journal._entries.Add(entry);

                    break;
                case "2":
                    foreach (Entry singleEntry in journal._entries)
                    {
                        Console.WriteLine($"{singleEntry._entryDate} {singleEntry._prompt} \n {singleEntry._response}");
                    }
                    break;
                case "3":
                    Console.WriteLine("load");
                    break;
                case "4":
                    Console.WriteLine("Save");
                    break;
                case "5":
                    Console.WriteLine("Thanks For Journaling today!");
                    break;
                default:
                    Console.WriteLine("Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}