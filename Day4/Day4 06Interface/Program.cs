/* We create interfaces using interface keyword. Just like clases interfaces contains
 * properties, method etc . but only decalartion but no implementations.
 * It is a complile time error if we provide implementation . Memmber are public by default
 * If access modifier is provided to interface then complile time error is thrown. 
 * Cannot contain fields. 
 * 
 * 
 */
using System;

namespace Day4_06Interface
{

    // Define the first interface
    // Interfaces are public and memebers are by default public and do not need access modifiers
    interface ICustomer1
    {
        // Method declaration
        // This method must be implemented by any class that implements this interface
        void Print1();
    }

    // Define the second interface that extends the first interface
    interface ICustomer2 : ICustomer1
    {
        // Method declaration
        // This method must be implemented by any class that implements this interface
        void Print2();
    }

    // Define a class that implements the second interface
    // Since ICustomer2 extends ICustomer1, Customer must implement methods from both interfaces
    public class Customer : ICustomer2
    {
        // Implementation of the Print1 method from ICustomer1
        public void Print1()
        {
            Console.WriteLine("Print1 method");
        }

        // Implementation of the Print2 method from ICustomer2
        public void Print2()
        {
            Console.WriteLine("Interface print method");
        }
    }

    // Main program class
    public class Interfaces
    {
        public static void Main()
        {
            // Create an instance of the Customer class
            Customer CC = new Customer();

            // Call the Print1 method, implemented from ICustomer1
            CC.Print1(); // Output: "Print1 method"

            // Call the Print2 method, implemented from ICustomer2
            CC.Print2(); // Output: "Interface print method"
        }
    }

}
