﻿/*Sorting a list of simple types in C# is a common operation 
 * and can be done efficiently using built-in methods
 * provided by the .NET Framework.
 */


using System;
using System.Collections.Generic;


namespace Day07_04_Sort_listOfSimpleTypes
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 5, 2, 8, 1, 9 };

            // Sorting the list in ascending order
            numbers.Sort();

            Console.WriteLine("Sorted list of integers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Reverse();

            Console.WriteLine("Sorted list of integers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }

}
