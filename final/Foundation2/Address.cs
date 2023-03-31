using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zip;
    private string _country;

    public Address()
    {

    }

    public Address(string street, string city, string state, string zip, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
        _country = country;
    }

    public bool CountryLocation()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string AddressDisplay()
    {
        return _street + " " + "\n" + _city + ", " + _state + " " + _zip + "\n" + _country;
    }
}