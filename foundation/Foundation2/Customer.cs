using System;
using System.Collections.Generic;
// Class representing a Customer
class Customer
{
    private string name;
    private Address address;

    // Constructor
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Method to check if the customer lives in the USA
    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }

    // Method to get the customer's name
    public string GetName()
    {
        return name;
    }

    // Method to get the customer's address
    public Address GetAddress()
    {
        return address;
    }
}