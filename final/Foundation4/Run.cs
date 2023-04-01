using System;

public class Run : Activity
{
    private double _distance;

    public Run(string type, string date, int minutes, double distance) : base (type, date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return Math.Round((_distance / _minutes) * 60, 1);
    }

    public override double GetPace()
    {
        return Math.Round((_minutes / _distance), 1);
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} {_type} ({_minutes} min) - Distance: {_distance} miles; Speed: {GetSpeed()} mph; Pace: {GetPace()} min per mile\n");
    }
}