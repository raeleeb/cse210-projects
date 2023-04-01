using System;

public class Cycle : Activity
{
    private double _speed;

    public Cycle(string type, string date, int minutes, double speed) : base (type, date, minutes)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return Math.Round(_minutes / GetPace(), 1);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return Math.Round((60 / _speed), 1);
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} {_type} ({_minutes} min) - Distance: {GetDistance()} miles; Speed: {_speed} mph; Pace: {GetPace()} min per mile\n");
    }
}