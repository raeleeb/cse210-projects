using System;

class Program
{
    // Exceeded Requirements:
    // Added menu error handling with try/catch statement and the menu will reset for the user
    // Added 60 second max time validation for activities so users don't get crazy
    // Reflecting activity will not repeat the same questions in 1 max session, tested
    static void Main(string[] args)
    {
        int userPrompt = 0; 
        while (userPrompt != 4)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Menu Options: ");
                Console.WriteLine("\n1. Start breathing activity");
                Console.WriteLine("2. Start reflecting activity");
                Console.WriteLine("3. Start listing activity");
                Console.WriteLine("4. Quit");

                Console.Write("\nSelect a choice from the menu: ");
                string userSelection = Console.ReadLine();
                userPrompt = int.Parse(userSelection); 

                if (userPrompt == 1)
                {
                    Breathing activity1 = new Breathing("Breathing","This activity will help you relax by walking you through breathing in and out slowly. " +
                                                        "Clear your mind and focus on your breathing.");
                    activity1.StartMessage();
                    activity1.GetDuration();
                    activity1.BreathingActivity();
                }
                else if (userPrompt == 2)
                {
                    Reflecting activity2 = new Reflecting("Reflecting","This activity will help you reflect on times in your life when you have shown strength " +
                                                        "and resilience. This will help you recognize the power you have and how you can use it in other aspects " +
                                                        "of your life.");
                    activity2.StartMessage();
                    activity2.GetDuration();
                    activity2.ReflectingActivity();   
                }
                else if (userPrompt == 3)
                {
                    Listing activity3 = new Listing("Listing","This activity will help you reflect on the good things in your life by having you list as many things " +
                                                        "as you can in a certain area.");
                    activity3.StartMessage();
                    activity3.GetDuration();
                    activity3.ListingActivity(); 
                }
                else if (userPrompt == 4)
                {
                    Console.WriteLine("\nGoodbye, my friend!");
                }
                else
                {
                    Console.Write("\nInvalid number - select a valid menu option and press enter. \nMenu resets in: ");
                    Thread.Sleep(1000);

                    for (int i = 3; i > 0; i--)
                    {
                        Console.Write(i);
                        Thread.Sleep(1000);
                        Console.Write("\b \b");
                    }                
                }
            }
            catch (FormatException) 
            {
               Console.Write("\nInvalid - enter a number from the menu options. \nMenu resets in: ");
               Thread.Sleep(1000);

                for (int i = 3; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }       
            }
        }
    } 
}