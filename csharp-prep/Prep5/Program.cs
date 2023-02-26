using System;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string num = Console.ReadLine();
        int number = int.Parse(num);

        return number;
    }

    static double SquareNumber(double number)
    {
        double squareNum = Math.Pow(number,2);

        return squareNum;
    }

    static void DisplayResult(string name, double number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int faveNumber = PromptUserNumber();

        double numSquared = SquareNumber(faveNumber);

        DisplayResult(userName, numSquared);
    }

}