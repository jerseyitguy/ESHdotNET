/*Multiple class inheritance occurs when a class inherits from more than one class. 
 * This can lead to various issues, including ambiguity and complexity, 
 * which are generally avoided in C#. C# supports single class inheritance 
 * but allows multiple interface inheritance to manage complex hierarchies. */

using System;


namespace Day4_08ProblemsofMultiInheritance
{

    class A
    {
        public void MethodA()
        {
            Console.WriteLine("Method A from class A");
        }
    }

    // Base class B
    // This class defines a method MethodB
    class B
    {
        public void MethodB()
        {
            Console.WriteLine("Method B from class B");
        }
    }

    // C# does not support multiple class inheritance, so attempting to inherit from multiple classes is not valid
    // The following commented code illustrates the invalid attempt to inherit from both A and B

    // Define a class C attempting to inherit from both A and B
    //To Show
    // class C : A, B
    // {
    // }

    // Instead, C# allows multiple interface inheritance,
    // which is demonstrated below

    // Define interface IA
    // Interfaces only declare method signatures and cannot provide implementations
    interface IA
    {
        void MethodA();
    }

    // Define interface IB
    // Interfaces can have methods with the same names as other interfaces
    interface IB
    {
        void MethodB();
    }

    // Define a class C that implements both IA and IB interfaces
    // Class C provides concrete implementations of the methods declared in the interfaces
    class C : IA, IB
    {
        // Implementation of MethodA from IA
        // This method fulfills the contract of IA
        public void MethodA()
        {
            Console.WriteLine("Method A from class C implementing IA");
        }

        // Implementation of MethodB from IB
        // This method fulfills the contract of IB
        public void MethodB()
        {
            Console.WriteLine("Method B from class C implementing IB");
        }
    }

//#endregion

    // Define the main program class
    class Program
    {
        static void Main()
        {
            // Create an instance of class C
            // This instance will be used to call methods from both IA and IB
            C objC = new();

            // Call MethodA implemented from IA
            // Output: "Method A from class C implementing IA"
            objC.MethodA();

            // Call MethodB implemented from IB
            // Output: "Method B from class C implementing IB"
            objC.MethodB();
        }
    }

}
