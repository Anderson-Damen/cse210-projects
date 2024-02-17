   using System;

public Entry()
{

    public void Display()
    {
        foreach (Entry singleEntry in journal._entries)
            {
                Console.WriteLine($"{singleEntry._entryDate} {singleEntry._prompt} \n {singleEntry._response}");
            }    
    }
}

