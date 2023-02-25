using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magicValue = Console.ReadLine();
        int magic = int.Parse(magicValue); 

        Console.Write("What is your guess? ");
        string guessValue = Console.ReadLine();
        int guess = int.Parse(guessValue); 

        if (magic > guess)
        {
            Console.WriteLine("Higher");
        }
        else if (magic == guess)
        {
            Console.WriteLine("You guessed it!");
        }
        else
        {
            Console.WriteLine("Lower");
        }
    }
}