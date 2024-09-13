/*Generics (List<T>): Allows you to create collections that can
 * store any type of data while ensuring type safety. 
 * Array Conversion (ToArray): Transforms a List into an array, 
 * which is required for using the range feature.
Range Operator (..): Provides a concise syntax to select a portion
 of a collection or array. Iteration (foreach): Simplifies looping 
through collections without needing to manage index variables.*/


using System;
using System.Collections.Generic;


namespace Day07_06_Working_with_Generic_list_class___Ranges
{
    class Program
    {
        static void Main()
        {
            // Step 1: Create a List of integers
            // Here, we are initializing a generic List of integers with values from 1 to 10.
            // The List<T> class is part of the System.Collections.Generic namespace, which 
            // allows us to create strongly-typed collections that store objects of a specified type (in this case, int).
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Step 2: Convert the List to an array
            // To use the range operator in C#, the data structure needs to support it.
            // Arrays in C# support ranges, so we convert the List to an array using the ToArray() method.
            // The ToArray() method returns a new array containing all the elements in the List.
            int[] numbersArray = numbers.ToArray();

            // Step 3: Use the range operator to select a subset of elements
            // The range operator [start..end] is a feature in C# 8.0 and later that allows us to select
            // a range of elements from an array or other data structures that support indexing.
            // Here, `2..5` means we are selecting elements from index 2 up to, but not including, index 5.
            // In this array: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
            // The selected range will be: [3, 4, 5]
            var range = numbersArray[2..5];

            // Step 4: Iterate over the range and print each element
            // The foreach loop is used to iterate over each element in the range.
            // Inside the loop, we print each number in the selected range.
            // This will output the numbers 3, 4, and 5, as these are the elements at indices 2, 3, and 4 in the original array.
            foreach (var number in range)
            {
                Console.WriteLine(number); // Outputs: 3, 4, 5
            }
        }
    }

}
