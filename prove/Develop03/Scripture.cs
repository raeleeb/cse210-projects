using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

public class Scripture
{
    private string _reference;
    private List<string> _verseText = new List<string>();

    public Scripture()
    {

    }

    public Scripture(string reference, List<string> verse)
    {
        _reference = reference;
        _verseText = verse;
    }

    public void GetRenderedTextPreSet1()
    {
        Reference r1 = new Reference("Mosiah", "2", "41");
        _reference = r1.GetReference();

        Verse v1 = new Verse();
        string text = v1.GetVersePreSet1();
        _verseText = text.Split(' ').ToList();
        
        Console.Write($"\n{_reference}");
        _verseText.ForEach(i => Console.Write(i + " "));
    }

    public void GetRenderedTextPreSet2()
    {
        Reference r2 = new Reference("Proverbs", "3", "5", "6");
        _reference = r2.GetReference();

        Verse v2 = new Verse();
        string text = v2.GetVersePreSet2();
        _verseText = text.Split(' ').ToList();
        
        Console.Write($"\n{_reference}");
        _verseText.ForEach(i => Console.Write(i + " "));
    }

    public int VerseCount()
    {
        int Length__verseText = _verseText.Count;
        return Length__verseText;
    }

    public void HideWords()
    {        
        Random random = new Random();
        List<int> check = new List<int>();
        int index = random.Next(_verseText.Count);

        int Length__verseText = _verseText.Count;

        string newRandom = "go";

        while (newRandom != "stop")
        {
            for (int i = 0; i < Length__verseText + 1; i++)
            {
                
                if (!check.Contains(index))
                {
                    check.Add(index);
                    string hideWord = _verseText[index];
                    Word w = new Word(hideWord);
                    string updateWord = w.Hide();
                    _verseText[index] = updateWord;
                    newRandom = "stop";
                }
                else
                {
                    index = random.Next(_verseText.Count);  
                }
            }
        }

        Console.Clear();

        Console.Write($"\n{_reference}");
        _verseText.ForEach(i => Console.Write(i + " "));
        AllHidden();
    }

    public int AllHidden()
    {
        int result = 0;
        int Length__verseText = _verseText.Count;

        foreach (string word in _verseText)
        {
            Word w = new Word(word);

            if (result == Length__verseText)
            {
                return result;
            }
            else if (w.GetHide() == 1)
            {
                result += 1;
            }
            else
            {
                result += 0;
            }
        }

    return result;  

    }
}
