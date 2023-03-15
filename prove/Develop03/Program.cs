using System;

class Program
{
    // Exceeding requirements:
    // When user types in 'quit' it is not case sensitive.
    // User has the option to pick from 2 scriptures.
    // Added extra Verse class.
    // Added error handling in Program.cs with try/catch statement.
    static void Main(string[] args)
    { 
        int scriptureChoice = 0;

        try
        {
            Console.WriteLine("\nLet's Memorzie! Choose a selection: ");
            Console.WriteLine("1. Mosiah 2:41");
            Console.WriteLine("2. Proverbs 3:5-6");
            Console.WriteLine("3. Quit");

            Console.Write(">> ");
            string userSelection1 = Console.ReadLine();
            scriptureChoice = int.Parse(userSelection1); 

            if (scriptureChoice == 1)
            {
                Scripture s1 = new Scripture();
                s1.GetRenderedTextPreSet1();
                int verseCount = s1.VerseCount();
                int userPrompt = -1;
                while (userPrompt != 0)
                {
                    Console.Write("\n\nPress enter to continue or type 'quit' to finish. ");

                    string userSelection = Console.ReadLine();

                    if (string.Equals(userSelection, "quit", StringComparison.InvariantCultureIgnoreCase))
                    {
                        break;
                    }
                    else if (s1.AllHidden() == verseCount)
                    {
                        break;
                    }
                    else
                    {
                        s1.HideWords();
                    }
                }
            }
            else if (scriptureChoice == 2)
            {
                Scripture s2 = new Scripture();
                s2.GetRenderedTextPreSet2();
                int verseCount = s2.VerseCount();
                int userPrompt = -1;
                while (userPrompt != 0)
                {
                    Console.Write("\n\nPress enter to continue or type 'quit' to finish. ");

                    string userSelection = Console.ReadLine();

                    if (string.Equals(userSelection, "quit", StringComparison.InvariantCultureIgnoreCase))
                    {
                        break;
                    }
                    else if (s2.AllHidden() == verseCount)
                    {
                        break;
                    }
                    else
                    {
                        s2.HideWords();
                    }
                }
            }
        }
        catch (FormatException) 
        {
            Console.WriteLine("\nInvalid number - restart the program."); 
        }

        Console.WriteLine("\nGoodbye, my friend!");
    }

}