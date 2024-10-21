using System;

class Program
{
    static void Main(string[] args)
    {
        // Create two addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("383 Rotherwel Drive", "Liverpool","UK","England");

        // Create two customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        Customer customer3 = new Customer("Lexman Okhitoya", address3);

        // Create products for the first order
        Product product1 = new Product("Laptop", "P1001", 1200.00, 1);
        Product product2 = new Product("Mouse", "P1002", 25.00, 2);

        // Create the first order and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        

        // Create products for the second order
        Product product3 = new Product("Smartphone", "P2001", 799.99, 1);
        Product product4 = new Product("Charger", "P2002", 19.99, 1);

        // Create the second order and add products
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display packing label, shipping label, and total price for each order

        // Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        // Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}\n");

        // Console.WriteLine(order3.GetPackingLabel());

    }
}