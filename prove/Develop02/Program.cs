using System;

class Program
{
    // Exceeding requirements: Added in some erroring handling with try/catch statements in 
    // Program and Journal classes.
    static void Main(string[] args)
    {
               
        Journal journal = new Journal();
        int userPrompt = 0; 
        while (userPrompt != 5)
        {
            try
            {
                Console.WriteLine("\nLet's journal - choose a selection: ");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Quit");

                Console.Write(">> ");
                string userSelection = Console.ReadLine();
                userPrompt = int.Parse(userSelection); 

                if (userPrompt == 1)
                {
                    journal.CreateJournalEntry();
                }
                else if (userPrompt == 2)
                {
                    journal.DisplayJournalEntries();
                }
                else if (userPrompt == 3)
                {
                    journal.SaveToFile();
                }
                else if (userPrompt == 4)
                {
                    journal.LoadFromFile();
                }
                else if (userPrompt == 5)
                {
                    Console.WriteLine("\nGoodbye, my friend!");
                }
                else
                {
                    Console.WriteLine("\nInvalid number - select a valid number and press enter.");
                }
            }
            catch (FormatException) 
            {
               Console.WriteLine("\nInvalid - enter a number from the selection."); 
            }
        };

    } 
}