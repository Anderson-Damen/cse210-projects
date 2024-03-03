using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public Journal()
    {
    }
public void Display()
    {
        string filename = "Journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string _entryDate = parts[0];
            string _prompt = parts[1];
            string _response = parts[2];
        }
    }
}
