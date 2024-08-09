/* Method hiding in C# occurs when a derived class defines a method with the same name as a method in its base class.
   This effectively hides the base class method, meaning that when you call the method on an instance of the derived class,
   the derived class's method is invoked, not the base class's method.
   This is different from method overriding, which requires the override keyword and must involve a method marked as virtual, abstract, or override in the base class.
*/

using System; // Using directive for the System namespace

namespace Day4_02MethodHiding
{
    // Base class Employee
    public class Employee
    {
        // Fields to store first and last names
        public string FirstName;
        public string LastName;

        // Method to print the full name
        public void PrintFullName()
        {
            // Print the full name in the format "FirstName LastName"
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    // Derived class PartTimeEmployee inheriting from Employee
    public class PartTimeEmployee : Employee
    {
        // Method hiding using the 'new' keyword
        public new void PrintFullName()
        {
            // Calling the base class method
            //base.PrintFullName();
            // Additional behavior specific to PartTimeEmployee can be added here
            // For example, uncommenting the next line will append "-Contractor" to the name
             Console.WriteLine(FirstName + " " + LastName + "-Contractor");
        }
    }

    // Derived class FullTimeEmployee inheriting from Employee
    public class FullTimeEmployee : Employee
    {
        // Default constructor
        public FullTimeEmployee()
        {
        }
    }

    // Main program class
    class Program
    {
        public static void Main()
        {
            // Creating an instance of FullTimeEmployee and setting properties
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "John"; // Set the first name to "ESH Solutions"
            FTE.LastName = "Thomas"; // Set the last name to "FullTime"
                                       // Calling the PrintFullName method from the base class Employee
            FTE.PrintFullName(); // Output: "John Thomas"

            // Creating an instance of PartTimeEmployee and setting properties
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Sam"; // Set the first name to "Part"
            PTE.LastName = "Peter"; // Set the last name to "time"
                                   // Casting PartTimeEmployee to Employee to call the base class method
            ((Employee)PTE).PrintFullName(); // Output: "sam Peter"

            // Calling the hidden PrintFullName method from the derived class PartTimeEmployee
            PTE.PrintFullName(); // Output: "Sam Peter" (plus any additional behavior if the commented line in PrintFullName is uncommented)
        }
    }

}
