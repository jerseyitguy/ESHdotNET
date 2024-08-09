/*C# does not support multiple class inheritance directly, you can achieve similar 
 * functionality by using interfaces. Interfaces allow a class to implement multiple 
 * sets of methods, even if those methods share the same names, without the 
 * complications of multiple class inheritance. This approach provides flexibility and 
 * helps to avoid the problems associated with multiple 
 * class inheritance.*/

using System;

namespace Day4_09MutlipleclassInheritanceusinginterfaces
{
    // Define interface IA with a method AMethod
    // Interfaces define method signatures that classes must implement
    interface IA
    {
        void AMethod();
    }

    // Class A implements interface IA
    // This class provides a concrete implementation for the AMethod defined in IA
    class A : IA
    {
        // Provide implementation for AMethod from IA
        public void AMethod()
        {
            Console.WriteLine("A");
        }
    }

    // Define interface IB with a method AMethod
    // This interface also defines a method with the same name as in IA
    // This illustrates how interfaces can have methods with the same name
    interface IB
    {
        void BMethod();
    }

    // Class B implements interface IB
    // This class provides a concrete implementation for the AMethod defined in IB
    class B : IB
    {
        // Method specific to class B, not defined in IB
        public void BMethod()
        {
            Console.WriteLine("B");
        }
    }

    // Class AB implements both IA and IB
    // Class AB demonstrates how a class can implement multiple interfaces and handle method naming conflicts
    class AB : IA, IB
    {
        // Instances of classes A and B
        // These instances are used to delegate method calls
        A a = new A();
        B b = new B();

        // Implement AMethod from IA
        // This implementation is chosen to resolve the method name conflict between IA and IB
        public void AMethod()
        {
            // Calls the AMethod from the instance of A
            // This uses the implementation from class A
            a.AMethod(); // Output: "A"
        }

        // Implement BMethod specific to class B
        // This method is not part of IA or IB but is specific to class B
        public void BMethod()
        {
            // Calls the BMethod from the instance of B
            // This uses the implementation from class B
            b.BMethod(); // Output: "B"
        }
    }

    class Program
    {
        public static void Main()
        {
            // Create an instance of class AB
            // This instance can use methods from both IA and IB
            AB ab = new();

            // Call methods on the instance of AB
            // This will invoke the appropriate method based on the implementation provided in AB
            ab.AMethod(); // Output: "A"
            ab.BMethod(); // Output: "B"
        }
    }

}
