using System;
using System.Collections.Generic;
// Class representing a Product
class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Method to calculate the total cost of the product
    public double GetTotalCost()
    {
        return price * quantity;
    }

    // Method to return the product's packing info
    public string GetPackingInfo()
    {
        return $"{name} (ID: {productId})";
    }
}
