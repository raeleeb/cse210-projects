using System;

public class Word
{
    private string _word;

    public Word()
    {

    }

    public Word(string word)
    {
        _word = word;
    }

    public string Hide()
    {
        return _word = new String('_', _word.Length); 
    }

    public int GetHide()
    {
        if (_word.Contains("_"))
        {
            return 1;
        }
        else 
        {
            return 0;
        }
    }
}