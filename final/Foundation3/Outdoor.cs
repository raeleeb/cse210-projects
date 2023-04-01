using System;

public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string type, string title, string description, string date, string time, Address address, string weather)
        : base(type, title, description, date, time, address)
    {
        _weather = weather;
    }

    public override void GetFullDetail()
    {
        Console.WriteLine($"Type: {_type}");
        GetStandardDetail();
        Console.WriteLine($"Forecast: {_weather}°");
    }
}