using System;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string type, string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(type, title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override void GetFullDetail()
    {
        Console.WriteLine($"Type: {_type}");
        GetStandardDetail();
        Console.WriteLine($"RSVP: {_rsvpEmail}");
    }
}