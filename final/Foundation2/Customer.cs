using System;

public class Customer
{
    public string CustomerName { get; private set; }
    private Address _address = new Address();

    public Customer()
    {

    }
    
    public Customer(string name)
    {
        CustomerName = name;
    }
    
    public Customer(string name, Address address)
    {
        CustomerName = name;
        _address = address;
    }

    public bool Location()
    {
        return _address.CountryLocation();
    }

    public string CustomerAddress()
    {   
        return _address.AddressDisplay();
    }
}