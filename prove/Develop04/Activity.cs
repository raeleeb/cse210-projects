using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity\n\n{_description}");
    }

    public void EndMessage()
    {
        Console.WriteLine("\n\n----- Hooray! Well done!! -----");
        Spinner(4);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        Spinner(5);
    }

    public int GetDuration()
    {
        _duration = -1; 
        while (_duration <= 60)
        {
            Console.Write("\nHow long, in seconds, would you like your session? Must be less than or equal to 60: ");
            string userResponse = Console.ReadLine();
            _duration = int.Parse(userResponse); 

            if (_duration > 60)
            {
                Console.WriteLine("Input should be a positive integer that is less than 61.");
                _duration = 0;
            }
            else
            {
                break;
            }
        }

        return _duration;
    }

    public void Spinner(int count)
    {
        List<string> animationString = new List<string>
        {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(count);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(750);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }

    public void CountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {       
            if (i >= 10)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b\b");
            }
            else if (i == 9)
            {
                Console.Write("  \b\b");
                Console.Write(i);
                Thread.Sleep(1000);
            }
            else
            { 
                Console.Write(" \b\b");
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b ");           
            }          
        }
    }


}

