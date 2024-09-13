
/*Anonymous methods in C# are a way to create inline methods
 without having to explicitly define a separate method. 
They allow you to write a code block that can be passed 
as a delegate parameter. */



using System;

namespace Day07_07_Anonymous_Method
{
    class Program
    {
        // Step 1: Define a delegate
        delegate void PrintMessage(string message);

        static void Main()
        {
            // Step 2: Create an anonymous method assigned to
            // the delegate
            PrintMessage print = delegate (string msg)
            {
                Console.WriteLine(msg);
            };

            // Step 3: Use the delegate to call the anonymous method
            print("Hello, Anonymous Method!");
        }
    }
}
