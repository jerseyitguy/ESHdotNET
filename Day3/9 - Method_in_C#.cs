/*
We will learn 

the structure of a method.
the difference between static and instance methods.

Why methods

Methods are also called as functions. These terms are used interchangeable.

Methods are extremely useful because they allow you to define your logic once, and use it, at many places.

Methods make the maintenance of your application easier.

Methods

[attributes]
access-modifiers return-type method-name (parameters)
{
Method Body
}

1. We will talk about attributes and access modifiers in a later session.
2. Return type can be any valid data type or void.
3. Method name can be any meaningful name
4. Parameters are optional.


Static Vs Instance methods

When a method declaration includes a static modifiers, that method is said to be a static method. When no static modifier is present, the method is said to be an instance method.

Static method is invoked using the class name, where as an instance method is invoked using as instance of the class.

The differences between instance methods and static methods is that multiple instance of a class can be created (or instantiated)and each instance has its own separate method. However, when a method is static. there are no instance of that method, and you can involve only that one definition of the static method.



*/

using System;

class Program
{
    public static void Main()
    {
        // Call the static method EvenNumbers to print even numbers up to 30
        Program.EvenNumbers(30);

        // Create an instance of the Program class
        Program P = new Program();
        
        // Call the instance method Add to sum 10 and 20
        int sum = P.Add(10, 20);

        // Print the sum
        Console.WriteLine("Sum = {0}", sum);
    }

    // Instance method to add two integers and return the sum
    public int Add(int FN, int SN)
    {
        return FN + SN;
    }

    // Static method to print even numbers up to the specified target
    public static void EvenNumbers(int Target)
    {
        int Start = 0;

        // Loop until Start is greater than the Target
        while (Start <= Target)
        {
            // Print the current value of Start if it is even
            if (Start % 2 == 0)
            {
                Console.WriteLine(Start);
            }
            // Increment Start by 1
            Start = Start + 1;
        }
    }
}
