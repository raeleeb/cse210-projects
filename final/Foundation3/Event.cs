using System;

public class Event
{
    protected string _type;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address = new Address();

    public Event(string type, string title, string description, string date, string time, Address address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void GetStandardDetail()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Location: {_address.AddressDisplay()}");
    }

    public void GetShortDescription()
    {
        Console.WriteLine($"Type: {_type}");
        Console.WriteLine($"Title: {_title}");  
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine("-------------------------------------------------------------------------------------------");       
    }

    public virtual void GetFullDetail()
    {

    }
}