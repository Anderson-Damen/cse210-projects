using System;

public class PromptGenerator
{
    public string[] _prompts = new string[]
    {
        "Who was an interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was my highest point today and what was my lowest point?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }
    
}