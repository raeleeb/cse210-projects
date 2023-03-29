using System;

class Program
{
    // Exceeded Requirements:
    // Added program menu error handling with try/catch statement 
    // Added goal type menu error handling with try/catch statement
    // When recording an event, added verbiage for user if the goal is already complete
    // Added error handling when user is recording an event, and returns to menu is there is nothing to record
    // Added error handling if file to be loaded doesn't exist or has a typo
    static void Main(string[] args)
    {
        Goal goal = new Goal();
        int userPrompt = 0; 
        while (userPrompt != 6)
        {
            try
            {
                Console.WriteLine($"\n---- You have {goal.GetTotalPoints()} points. ----\n");

                Console.WriteLine("Menu Options:");
                Console.WriteLine("\t1. Create New Goal");
                Console.WriteLine("\t2. List Goals");
                Console.WriteLine("\t3. Save Goals");
                Console.WriteLine("\t4. Load Goals");
                Console.WriteLine("\t5. Record Event");
                Console.WriteLine("\t6. Quit");
                Console.Write("\nSelect a choice from the menu: ");

                string userSelection = Console.ReadLine();
                userPrompt = int.Parse(userSelection); 

                if (userPrompt == 1)
                {
                    goal.CreateNewGoal();
                }
                else if (userPrompt == 2)
                {
                    Console.WriteLine("\nThe goals are: ");
                    goal.ListGoals();
                }
                else if (userPrompt == 3)
                {
                    goal.SaveToFile();
                }
                else if (userPrompt == 4)
                {
                    goal.LoadFromFile();
                }
                else if (userPrompt == 5)
                {
                    Console.WriteLine("\nThe goals are: ");
                    goal.RecordEvent();
                }
                else if (userPrompt == 6)
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
               Console.WriteLine("\nInvalid - enter a number from the menu."); 
            }
        }
    }
}