/*Multiple class inheritance occurs when a class inherits from more than one class. 
 * This can lead to various issues, including ambiguity and complexity, 
 * which are generally avoided in C#. C# supports single class inheritance 
 * but allows multiple interface inheritance to manage complex hierarchies. 
 */

using System;

namespace Day4_07ExplictInterfaceImplementation
{
    // Define the first interface I1
    // This interface declares a method named InterfaceMethod
    interface I1
    {
        void InterfaceMethod();
    }

    // Define the second interface I2
    // This interface also declares a method named InterfaceMethod
    interface I2
    {
        void InterfaceMethod();
    }

    // Define a class that implements both interfaces I1 and I2
    public class Program : I1, I2
    {
        // Explicit implementation of the InterfaceMethod from I1
        // This method is implemented specifically for I1 and cannot be called directly
        void I1.InterfaceMethod()
        {
            Console.WriteLine("I1 interface method");
        }

        // Explicit implementation of the InterfaceMethod from I2
        // This method is implemented specifically for I2 and cannot be called directly
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 interface method");
        }

        // Main method
        public static void Main()
        {
            // Create an instance of the Program class
            Program P = new Program();

            // This line will cause a compile-time error because the method is explicitly implemented
            // P.InterfaceMethod(); // Uncommenting this line will cause a compile-time error

            // Call the InterfaceMethod from I1
            // Cast the Program instance to the I1 interface type
            ((I1)P).InterfaceMethod(); // Output: "I1 interface method"

            // Call the InterfaceMethod from I2
            // Cast the Program instance to the I2 interface type
            ((I2)P).InterfaceMethod(); // Output: "I2 interface method"
        }
    }

}
