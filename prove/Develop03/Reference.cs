using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verseStart;
    private string _verseEnd;

    public Reference()
    {

    }

    public Reference(string book, string chapter, string start)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = start;
        _verseEnd = "";
    }

    public Reference(string book, string chapter, string start, string end)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = start;
        _verseEnd = end;
    }

    public string GetReference()
    {
        if (_verseEnd != "")
        {
            return _book + " " + _chapter + ":" + _verseStart + "-" + _verseEnd + " ";
        }
        else
        {
            return _book + " " + _chapter + ":" + _verseStart + " ";
        }
    }
}