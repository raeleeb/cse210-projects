using System;
using System.Collections.Generic;

public class Entry
{
    // Load and display formatted prompt and response 
    public string date;
    public string prompt; 
    public string response;


    public Entry(string _date, string _prompt, string _response)
    {
        date = _date;
        prompt = _prompt;
        response = _response;
    }

    // Formatting the display of entries.
    public void DisplayEntry()
    {
        Console.WriteLine($"\n{date}");

        Console.WriteLine($"Prompt: {prompt}");

        Console.WriteLine($"Response: {response}");
    }

    // Delimiting the Journal list entries with pipes and returning the values.
    public string DelimitToProcess()
    {
        return string.Format("{0}|{1}|{2}", date,"Prompt: " + prompt,"Response: " + response);
    }

    

}