using System;

public class Order
{
    private Customer _customer = new Customer();
    private double _total;
    private int _shippingfee;
    public List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public int ShippingFee()
    {
        if (_customer.Location() == true)
        {
            int feeUSA = 5;
            _shippingfee = feeUSA;
            return _shippingfee;
        }
        else
        {
            int feeOutside = 35;
            _shippingfee = feeOutside;
            return _shippingfee;
        }
    }

    public double CalculateProductTotal()
    {
        Console.WriteLine("--------Total Order Price--------");
        
        foreach (Product product in _products)
        {
            double total = product.CalculatePrice();
            _total += total;
        }

        ShippingFee();

        return _total + _shippingfee;
    }

    public void PackingLabel()
    {
        Console.WriteLine("----------Packing Label----------");

        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.ProductName} {product.ProductId}");
        }
    }

    public void ShippingLabel()
    {
        Console.WriteLine("---------Shipping Label---------");
        Console.WriteLine($"{_customer.CustomerName}\n{_customer.CustomerAddress()}");
    }
}