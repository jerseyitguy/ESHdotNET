/* Method overriding allows a derived class to provide a specific implementation of a 
 * method that is already defined in its base class.
   The method in the base class must be marked as virtual, abstract, or override. */

using System; // Using directive for the System namespace


namespace Da4_04Difference_between_overriding_methodhiding
{
    // Base class definition
    public class Baseclass
    {
        // Virtual method that can be overridden in derived classes
        public virtual void Print()
        {
            // Print a message indicating this is the base class method
            Console.WriteLine("I am base class print method");
        }
    }

    // Derived class inheriting from Baseclass
    public class DerivedClass : Baseclass
    {
        // Override the virtual method from the base class
        // Note: This uses the 'override' keyword to provide a new implementation
        public override void Print()
        {
            // Print a message indicating this is the derived class method
            Console.WriteLine("I am derived class print method");
        }
    }

    // Main program class
    public class Program
    {
        public static void Main()
        {
            // Creating a Baseclass reference pointing to a DerivedClass object
            // This demonstrates polymorphism, where a base class reference can point to a derived class object
            // To Show 
            // Baseclass B = new(); 

            Baseclass B = new DerivedClass();

            // Calling the Print method on the base class reference
            // Due to polymorphism, the overridden method in the DerivedClass is called
            B.Print(); // Output: "I am derived class print method"

            // Explanation:
            // Although B is a reference of type Baseclass, it points to an instance of DerivedClass.
            // The Print method in DerivedClass overrides the Print method in Baseclass.
            // When B.Print() is called, the overridden method in DerivedClass is executed instead of the method in Baseclass.
        }
    }
}
