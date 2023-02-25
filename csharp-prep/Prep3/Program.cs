using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 21);

        //Console.WriteLine(magic);

        int game = -1;
        do
        {
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
            magic = game;
        }
        else
        {
            Console.WriteLine("Lower");
        }
        } while (magic != game);

    }
}