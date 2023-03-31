using System;

public class Product
{
    public string ProductName { get; private set; }
    public string ProductId { get; private set; }
    public double Price { get; private set; }
    public double Quantity { get; private set; }
    
    public Product(string name, string id, double price, double quantity)
    {
        ProductName = name;
        ProductId = id;
        Price = price;
        Quantity = quantity;
    }

    public double CalculatePrice()
    {
        double cost = Math.Round(Price * Quantity, 2);
        
        return cost;
    }
}