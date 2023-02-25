using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userValue = Console.ReadLine();
        int value = int.Parse(userValue); 

        string letter = "";

        if (value >= 90)
        {
            letter = "A";
        }
        else if (value >= 80)
        {
            letter = "B";
        }
        else if (value >= 70)
        {
            letter = "C";
        }
        else if (value >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Grade: {letter}");

        if (value >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Next time you will get it, keep trying.");
        }
    }
}