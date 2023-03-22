using System;

public class Reflecting : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "--- Think of a time when you stood up for someone else. ---",
        "--- Think of a time when you did something really difficult. ---",
        "--- Think of a time when you helped someone in need. ---",
        "--- Think of a time when you did something truly selfless. ---"
    };
    private List<string> _reflectionQuestions = new List<string>()
    {
        "> Why was this experience meaningful to you?",
        "> Have you ever done anything like this before?",
        "> How did you get started?",
        "> How did you feel when it was complete?",
        "> What made this time different than other times when you were not as successful?",
        "> What is your favorite thing about this experience?",
        "> What could you learn from this experience that applies to other situations?",
        "> 5What did you learn about yourself through this experience?",
        "> How can you keep this experience in mind in the future?",
        "> Would you share this experience with others?",
        "> What prompted you to do it?",
        "> Did you pattern yourself after anyone in your life?",
        "> Just, why?",
        "> What did you gain in return?"
    };
    private int _countDownTimer = 5;
    private int _spinnerTimer = 7;

    public Reflecting(string name, string description) : base(name, description)
    {
   
    } 

    public void ReflectingActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(3);
        
        int counter = _duration;

        Console.WriteLine("\nConsider the following prompt:");

        Random random1 = new Random();
        int indexOne = random1.Next(_prompts.Count);
        string prompt = _prompts[indexOne];

        Console.WriteLine($"\n{prompt}");

        Console.Write("\nWhen you have something in mind, press enter to continue.");

        while (Console.ReadKey().Key == ConsoleKey.Enter)
        {
            Console.WriteLine("\n\nNow ponder on each of the following questions as they related to the experience.");
            Console.Write("You many begin in: ");
            Thread.Sleep(1000);

            for (int i = _countDownTimer; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            break;
        }

        Console.Clear();

        Random random2 = new Random();
        int indexTwo = random2.Next(_reflectionQuestions.Count);
        
        List<int> check = new List<int>();

        while (_duration >= 0)
        {
            if (!check.Contains(indexTwo))
            {
                check.Add(indexTwo);
                string reflectionQuestion = _reflectionQuestions[indexTwo];

                Console.Write($"\n{reflectionQuestion} ");
                Spinner(_spinnerTimer);
                Thread.Sleep(1000);

                _duration -= _spinnerTimer;
                if (_duration <= 0)
                {
                    break;
                }
            }
            else
            {
                indexTwo = random2.Next(_reflectionQuestions.Count);
            }
        }

        _duration = counter;
        EndMessage();
    }
}