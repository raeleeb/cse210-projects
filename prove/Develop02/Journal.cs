using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Create, display, save and load journal to user
    public List<Entry> entries = new List<Entry>();


    public Journal()
    {

    }

    // Creating a journal entry and adding the list of entries.
    public void CreateJournalEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Response: ");
        string response = Console.ReadLine();

        entries.Add(new Entry(date, prompt, response));
    }

    // Looping through each entry and displaying to the console.
    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    // Returns random question in the list.
    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "If I had one thing I could do over today, what would it be?",
            "What was the best part of my day?",
            "What increased my motivation today?",
            "Who could I serve tomorrow and why?",
            "Share a funny story from the past.",
            "Who is one of your favorite people and why?",
            "Give your kids advice when they turn 16.",
            "Give your kids advice when they turn 13.",
            "Give your kids advice when they turn 18.",
            "Give your kids advice when they turn 21.",
            "Give your kids advice when they serve a mission.",
            "Give your kids advice when they have their first baby.",
            "Give your kids advice on marriage.",
            "What consumed your mind and thoughts today?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Count);

        return prompts[index];
    }

    // Allows user to create file name and writes to text file.
    public void SaveToFile()
    {
        Console.Write("Please enter the file name without .txt extension: ");
        string userFile = Console.ReadLine();
        userFile = userFile + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFile))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.DelimitToProcess());
            }
        
        }

    }

    // Allows user to load pre-existing file and displays. 
    public void LoadFromFile()
    {
        Console.Write("Please enter the saved file name without .txt extension: ");
        string userFile = Console.ReadLine();
        userFile = userFile + ".txt";

        try
        {
        string fileName = userFile;
        string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
            string[] parts = line.Split("|"); 

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            entries.Add(new Entry(date, prompt, response));
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("\nFile doesn't exist, try again.");
        }

    

    }
    
}

    



    