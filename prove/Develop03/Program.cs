using System;

class Program
{
    static void Main(string[] args)
    {
        //Reference reference1 = new Reference("Proverbs","3","5","-6");
        //Console.WriteLine(reference1.GetReference());
        string quit = "";
        while(quit != "quit")
        {
            Scripture scripture1 = new Scripture();
            string _verseText = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways achknowledge him, and he shall direct thy paths.";
            string[] _verseArray = _verseText.Split(' ');
            scripture1.FillList(_verseArray);
            scripture1.PrintScripture();
        }
    }
}