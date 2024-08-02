/*
We will learn 

The 4 types of method parameters
Value Parameters
Reference Parameters
Out Parameters
Parameter Arrays
Method parameters Vs Method Arguments


Method parameters types
There are 4 different types of parameters a method can have

1. Value Parameters: Creates a copy of the parameter passed, so modifications does not affect each other.
2. Reference Parameters: The ref method parameter keyword on a method parameter causes a method to refer to the same variable that was passed into the method. Any changes made to the parameter in the method in the method will be reflected in that variable when control passes back to the calling method.
3. Out Parameters: Use when you want a method to return more than one value.
4.Parameter Arrays: The params keyword lets you specify a method parameter that takes a variable number of arguments. You can send a comma separated list of arguments, or an array, or no arguments Params keyword should be the last on in a method declaration, and only one params keyword is permitted in a method declaration.

*/

using System;

class Program
{
    public static void Main()
    {
        // Initialize an array of integers with 3 elements
        int[] Numbers = new int[3];

        // Assign values to the elements of the array
        Numbers[0] = 101;
        Numbers[1] = 102;
        Numbers[2] = 103;

        // Call the ParamsMethod and pass the array as an argument
        ParamsMethod(Numbers);
        
        // You can also call the ParamsMethod with individual integer arguments
        ParamsMethod(201, 202, 203, 204);
    }

    // Method that accepts a variable number of integer parameters
    public static void ParamsMethod(params int[] Numbers)
    {
        // Print the number of elements in the array
        Console.WriteLine("There are {0} elements", Numbers.Length);

        // Iterate through each element in the array and print it
        foreach (int i in Numbers)
        {
            Console.WriteLine(i);
        }
    }
}
