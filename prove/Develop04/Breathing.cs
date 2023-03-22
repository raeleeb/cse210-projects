using System;

public class Breathing : Activity
{
    private int _breatheIn = 3;
    private int _breatheOut = 4;
    public Breathing(string name, string description) : base(name, description)
    {
   
    } 

    public void BreathingActivity()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(3);
        
        int counter = _duration;

        Console.Write("\n----- BEGIN -----");

        while (_duration >= 0)
        {
            Console.Write("\nBreathe in for 3 seconds... ");
            CountDown(_breatheIn);
            Thread.Sleep(500);
            _duration -= _breatheIn;
            if (_duration <= 0)
            {
                break;
            }

            Console.Write("\nBreathe out for 4 seconds... ");
            CountDown(_breatheOut);
            Thread.Sleep(500);
            _duration -= _breatheOut;
            if (_duration <= 0)
            {
                break;
            }

            Console.Write("\n");
        }

        _duration = counter;
        EndMessage();
    }
}