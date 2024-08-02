
/*
 we will discuss
1. Arrays
2. Advantages and dis-advantages of arrays

Advantages: Arrays are strongly typed.

Disadvantages: Arrays cannot grow in size once initialized. Have to rely on integral indices to store or retrieve items from the array

*/
using System;
class Program
{
    public static void Main()
    {
        // Initialize and assign values in different lines
        int[] EvenNumbers = new int[3];
        EvenNumbers[0] = 0;
        EvenNumbers[1] = 2;
        EvenNumbers[2] = 4;

        // Initialize and assign values in the same line
        int[] OddNumbers = { 1, 3, 5 };

        Console.WriteLine("Printing EVEN Numbers");

        // Retrieve and print even numbers from the array
        for (int i = 0; i < EvenNumbers.Length; i++)
        {
            Console.WriteLine(EvenNumbers[i]);
        }

        Console.WriteLine("Printing ODD Numbers");

        // Retrieve and print odd numbers from the array
        for (int i = 0; i < OddNumbers.Length; i++)
        {
            Console.WriteLine(OddNumbers[i]);
        }
    }
}