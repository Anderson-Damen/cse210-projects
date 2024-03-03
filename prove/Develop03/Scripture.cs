using System;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private string _Reference;

    public void FillList(String[] _verseArray)
    {
        foreach (string word in _verseArray)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void PrintScripture()
    {
        foreach(Word newWord in _words)
        {
            Console.Write($"{newWord.GetWordText()} ");
        }
    }

}