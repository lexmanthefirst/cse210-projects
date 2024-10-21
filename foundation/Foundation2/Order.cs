using System;
using System.Collections.Generic;
// Class representing an Order
class Order
{
    private List<Product> products;
    private Customer customer;

    // Constructor
    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Method to calculate the total cost of the order, including shipping
    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product product in products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost
        total += customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    // Method to generate the packing label
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in products)
        {
            packingLabel += product.GetPackingInfo() + "\n";
        }
        return packingLabel;
    }

    // Method to generate the shipping label
    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}\n";
        return shippingLabel;
    }
}
