using System;

public class Swim : Activity
{
    private int _laps;

    public Swim(string type, string date, int minutes, int laps) : base (type, date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return Math.Round((_laps * 50 / 1000 * 0.62), 1);
    }

    public override double GetSpeed()
    {
        return Math.Round((GetDistance() / _minutes) * 60, 1);
    }

    public override double GetPace()
    {
        return Math.Round((60 / GetSpeed()), 1);
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} {_type} ({_minutes} min) - Distance {GetDistance()} miles; Speed: {GetSpeed()} mph; Pace: {GetPace()} min per mile\n");
    }
}