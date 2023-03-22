using System;

public class Listing : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "--- Who are people that you appreciate? ---",
        "--- What are personal strengths of yours? ---",
        "--- Who are people that you have helped this week? ---",
        "--- When have you felt the Holy Ghost this month? ---",
        "--- Who are some of your personal heroes? ---"
    };
    private List<string> _inputs = new List<string>();
    private int _countDownTimer = 5;

    public Listing(string name, string description) : base(name, description)
    {
   
    } 

    public void ListingActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(3);
        
        int counter = _duration;

        Console.WriteLine("\nList as many responses as you can to the following prompt:");

        Random random1 = new Random();
        int indexOne = random1.Next(_prompts.Count);
        string prompt = _prompts[indexOne];

        Console.WriteLine($"\n{prompt}");

        Console.Write("\nYou many begin in: ");
        Thread.Sleep(1000);

        for (int i = _countDownTimer; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.Write("\n");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            _inputs.Add(userInput);
        }
        
        Console.Write($"You listed {_inputs.Count} items!");

        _duration = counter;
        EndMessage();
    }
}