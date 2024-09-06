//Access Modifiers
//Private members are available only with in the containing type,
//where as public members are available any where. There is no restriction.
//Protect members are available, with in the containing type
//and
//to the types that derive from the containing tpee.

//Public member are available any where no restrictions

using System;



namespace Day06_06_Access_Modifiers
{
    internal class InternalClass
    {
        // Public field: Accessible from anywhere as long as the class is accessible.
        public string PublicField = "Public Field";

        // Private field: Accessible only within this class.
        private string PrivateField = "Private Field";

        // Internal field: Accessible only within the same assembly.
        internal string InternalField = "Internal Field";

        // Public method: Accessible from anywhere as long as the class is accessible.
        public void DisplayFields()
        {
            Console.WriteLine(PublicField);    // Accessible within the class
            Console.WriteLine(PrivateField);   // Accessible within the class
            Console.WriteLine(InternalField);  // Accessible within the class
        }

        // Private method: Accessible only within this class.
        private void PrivateMethod()
        {
            Console.WriteLine("This is a private method.");
        }

        // Internal method: Accessible only within the same assembly.
        internal void InternalMethod()
        {
            Console.WriteLine("This is an internal method.");
        }
    }

    // Another class in the same assembly to demonstrate access
    public class AnotherClassInSameAssembly
    {
        public void AccessInternalClass()
        {
            InternalClass internalClass = new InternalClass();

            // Accessing public member
            Console.WriteLine(internalClass.PublicField); // Accessible

            // Accessing internal member
            Console.WriteLine(internalClass.InternalField); // Accessible within the same assembly

            // Attempting to access private member (Uncommenting this will cause a compile error)
            // Console.WriteLine(internalClass.PrivateField); // Not accessible

            // Accessing public method
            internalClass.DisplayFields(); // Accessible

            // Attempting to access private method (Uncommenting this will cause a compile error)
            // internalClass.PrivateMethod(); // Not accessible

            // Accessing internal method
            internalClass.InternalMethod(); // Accessible within the same assembly
        }
    }

    // Main class
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of the InternalClass
            InternalClass internalClass = new InternalClass();

            // Accessing public member
            Console.WriteLine(internalClass.PublicField); // Accessible

            // Attempting to access private member (Uncommenting this will cause a compile error)
            // Console.WriteLine(internalClass.PrivateField); // Not accessible

            // Accessing internal member
            Console.WriteLine(internalClass.InternalField); // Accessible within the same assembly

            // Accessing public method
            internalClass.DisplayFields(); // Accessible

            // Attempting to access private method (Uncommenting this will cause a compile error)
            // internalClass.PrivateMethod(); // Not accessible

            // Accessing internal method
            internalClass.InternalMethod(); // Accessible within the same assembly

            // Accessing members from another class in the same assembly
            AnotherClassInSameAssembly anotherClass = new AnotherClassInSameAssembly();
            anotherClass.AccessInternalClass();
        }
    }

}
