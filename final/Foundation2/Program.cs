using System;

class Program
{
    static void Main(string[] args)
    {
        //Customer Order #1
        Address a1 = new Address("4087 Windsor Way","South Jordan","UT","84009","USA");
        Customer c1 = new Customer("Jenae Smith",a1);

        Product p1 = new Product("Apple","APP01",1.35,5);
        Product p2 = new Product("Oatmeal","OAT02",3.99,3);
        Product p3 = new Product("Milk","MIL03",2.35,1);

        Order o1 = new Order(c1);
        o1._products.Add(p1);
        o1._products.Add(p2);
        o1._products.Add(p3);

        o1.ShippingLabel();
        o1.PackingLabel();
        Console.WriteLine($"${o1.CalculateProductTotal()}\n\n");

        //Customer Order #2
        Address a2 = new Address("14 York Street","Toronto","ON","M5J0B1","CAN");
        Customer c2 = new Customer("Tim Lawson",a2);

        Product p4 = new Product("Banana","BAN04",.35,7);
        Product p5 = new Product("Flour","FLO05",2.99,2);
        Product p6 = new Product("Ragu","RAG06",2.95,3);
        Product p7 = new Product("Spaghetti","SPA07",2.25,4);

        Order o2 = new Order(c2);
        o2._products.Add(p4);
        o2._products.Add(p5);
        o2._products.Add(p6);
        o2._products.Add(p7);

        o2.ShippingLabel();
        o2.PackingLabel();
        Console.Write($"${o2.CalculateProductTotal()}\n\n");
    }
}