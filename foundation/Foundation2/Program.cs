using System;

public class Program
{
    public static void Main()
    {
        Product product1 = new Product("Laptop", 101, 800.00, 1);
        Product product2 = new Product("Mouse", 102, 20.00, 2);
        Product product3 = new Product("Keyboard", 103, 50.00, 1);

        
        Address address = new Address("123 Jack St", "New York", "NY", "USA");

        Customer customer = new Customer("Daniel Herrera", address);

        List<Product> productList = new List<Product> { product1, product2, product3 };

        Order order = new Order(productList, customer);

        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order.GetTotalPrice()}");
    }
}