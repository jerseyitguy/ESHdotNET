/*Attributes
Attributes allow you to add declaration information to your programs. 
This information can then be queried at runtime using reflection.

There are several Pre-defined Attributes provided by .NET.  It is
 also possible to create your own custom Attributes.


*/

namespace Day05_07_Attributes
{
    public class Calculator
    {
        // Mark this method as obsolete with a message indicating a preferred alternative
        // To Show
        [Obsolete("Use the AddNumbers method instead")]
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int AddNumbers(int x, int y)
        {
            return x + y;
        }
    }

    // Custom Attribute Definition
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)] // Specifies where the attribute can be applied
    public class CA_AuthorAttribute : Attribute
    {
        public string Name { get; }
        public string Version { get; }

        // Constructor that takes name and version as parameters
        public CA_AuthorAttribute(string name, string version)
        {
            Name = name;
            Version = version;
        }
    }

    // Apply the custom attribute to a class and a method
    [CA_Author("John Doe", "1.0")]
    public class SampleClass
    {
        [CA_Author("John Doe", "1.0")]
        public void SampleMethod()
        {
            Console.WriteLine("Sample method executed.");
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Using the Calculator class
            Calculator calc = new Calculator();
            int result = calc.Add(10, 20); // This will generate a warning due to the [Obsolete] attribute
            Console.WriteLine("Result: " + result);

            // Using reflection to retrieve custom attribute information
            Type type = typeof(SampleClass);
            object[] attributes = type.GetCustomAttributes(false);

            foreach (Attribute attr in attributes)
            {
                if (attr is CA_AuthorAttribute author)
                {
                    Console.WriteLine("Class {0} authored by {1}, version {2}", type.Name, author.Name, author.Version);
                }
            }

            // Retrieve method-level attributes
            var methodInfo = type.GetMethod("SampleMethod");
            var methodAttributes = methodInfo.GetCustomAttributes(typeof(CA_AuthorAttribute), false);

            foreach (CA_AuthorAttribute author in methodAttributes)
            {
                Console.WriteLine("Method {0} authored by {1}, version {2}", methodInfo.Name, author.Name, author.Version);
            }
        }
    }
}
