using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment asst1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(asst1.GetSummary());
        Console.WriteLine();

        MathAssignment asst2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(asst2.GetSummary());
        Console.WriteLine(asst2.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment asst3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(asst3.GetSummary());
        Console.WriteLine(asst3.GetWritingInformation());
    }
}