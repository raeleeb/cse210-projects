using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int num = -1;
        do
        {

            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            int value = int.Parse(userInput);

            if (value != 0)
            {
                numbers.Add(value);
            }
            else
            {
                int sum = numbers.Sum();
                Console.WriteLine($"The sum is: {sum}");

                double average = numbers.Average();
                Console.WriteLine($"The average is: {average}");

                int max = numbers.Max();
                Console.WriteLine($"The largest number is: {max}");

                num = 0;
            }

        } while (num != 0);
    }
}