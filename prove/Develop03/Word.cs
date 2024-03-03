using System;

public class Word
{
    private string _wordText;
    private bool _visible = true;

    public Word(string text)
    {
        _wordText = text;
    }
    public string GetWordText()
    {
        return _wordText;
    } 
}