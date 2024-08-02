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

class Circle
{
    // Static field to hold the value of PI
    public static float _PI;
    
    // Instance field to hold the radius of the circle
    int _Radius;

    // Static constructor to initialize the static field
    static Circle()
    {
        Console.WriteLine("Static constructor called");
        Circle._PI = 3.141F; // Assign the value of PI
    }

    // Instance constructor to initialize the radius of the circle
    public Circle(int Radius)
    {
        Console.WriteLine("Instance constructor called");
        this._Radius = Radius; // Assign the radius
    }

    // Method to calculate the area of the circle
    public float CalculateArea()
    {
        return Circle._PI * this._Radius * this._Radius; // Area formula: PI * radius^2
    }
}

class Program
{
    public static void Main()
    {
        // Accessing the static field without creating an instance
        Console.WriteLine(Circle._PI);
        
        // Creating an instance of the Circle class
        Circle circle = new Circle(5);

        // Calculating and displaying the area of the circle
        float area = circle.CalculateArea();
        Console.WriteLine("Area of the circle: " + area);
    }
}
