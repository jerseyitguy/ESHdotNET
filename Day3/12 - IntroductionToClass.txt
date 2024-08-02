/*
We will learn

Static class members
Instance class members
Difference between static and instance members
An example explaining when you should make certain member static


Static and instance class members
When a class members includes a static modifier, the member is called as static member.
When no static modifiers is present the member is called as non static members or instance member

Static member: are invoked using class name, where as instance members are invoked using instance(Objects) of the class

An instance member belongs to specific instance (object) of a class . If I create 3 objects of a class, I will have 3 sets of instance members in the memory, where as there will ever be only one copy of a static member, no matter how many instance of a class are created

Note: Class members =  fields, methods, properties, events, indexers, Constructors.


Static constructor
Static constructor are used to initialize static fields in a class 

You declare a static constructor by using the keyword static in front of the constructor name.

Static constructor is called only once, no matter how many instances you create.

Static constructor are called before instance constructors.
*/


using System;

class Customer
{
    // Private fields to store the first and last names
    string _firstName;
    string _lastName;

    // Parameterless constructor that calls the parameterized constructor
    // with default values for first and last names
    public Customer()
        : this("No FirstName Provided", "No LastName Provided")
    {
    }

    // Parameterized constructor that initializes the first and last names
    public Customer(string FirstName, string LastName)
    {
        this._firstName = FirstName; // Assign the provided first name to the field
        this._lastName = LastName;   // Assign the provided last name to the field
    }

    // Method to print the full name of the customer
    public void PrintFullName()
    {
        Console.WriteLine("Full Name = {0}", this._firstName + " " + this._lastName);
    }

    // Destructor to clean up resources
    ~Customer()
    {
        // Clean up code (called when the object is destroyed)
    }
}

class Program
{
    static void Main()
    {
        // Create a Customer object using the parameterless constructor
        Customer customer1 = new Customer();
        // Print the full name of customer1
        customer1.PrintFullName();

        // Create a Customer object using the parameterized constructor
        Customer customer2 = new Customer("John", "Doe");
        // Print the full name of customer2
        customer2.PrintFullName();
    }
}
