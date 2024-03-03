using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _startVerseNum;
    private string _endVerseNum;

    public string GetReference()
    {
        string text = $"{_book} {_chapter}:{_startVerseNum}{_endVerseNum}";
        return text;
    }
}