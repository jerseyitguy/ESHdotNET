/*A generic class in C# allows you to create classes that 
 * can work with any data type without specifying the 
 * data type in advance. This is useful when you want to
 * create a class that can handle different types of data 
 * in a type-safe manner.*/

using System;


namespace Day07_01_Generics_in_C_
{
    public class Container<T>
    {
        public T Value { get; set; }
    }

    // Using the generic class
    class Program
    {
        static void Main()
        {
            // Create a Container for an integer
            Container<int> intContainer = new Container<int>();
            intContainer.Value = 42;
            Console.WriteLine(intContainer.Value);

            // Create a Container for a string
            Container<string> stringContainer = new Container<string>();
            stringContainer.Value = "Hello";
            Console.WriteLine(stringContainer.Value);
        }
    }

}
