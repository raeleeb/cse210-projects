using System;

public class Lecture : Event
{
    private string _speaker;
    private string _capacity;

    public Lecture(string type, string title, string description, string date, string time, Address address, string speaker, string capacity)
        : base(type, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void GetFullDetail()
    {
        Console.WriteLine($"Type: {_type}");
        GetStandardDetail();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}