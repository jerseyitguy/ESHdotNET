/* Inheritance in C# is a fundamental object-oriented programming concept that 
 * allows a class to inherit properties, methods, and other members from another class. 
 * This promotes code reuse and establishes a hierarchical relationship between classes.
 */


// C# supports only single class inheritance.
// C# supports multiple interface inheritance.
// A Child class is a specialization of a base class.
// Base classes are automatically instantiated before derived classes.
// Parent Class constructor executes before child class constructor.

using System; // Using directive for the System namespace

// Base class

namespace Day4_01Inheritance
{
    public class Employee
    {
        // Properties common to all employees
        public string Name { get; set; } // Property to store the name of the employee
        public int EmployeeID { get; set; } // Property to store the employee ID

        // Method common to all employees
        public void Work()
        {
            // Method to simulate working
            Console.WriteLine($"{Name} is working."); // Display a message indicating the employee is working
        }

        // Virtual method that can be overridden by derived classes
        public virtual void CalculateSalary()
        {
            // Virtual method to calculate salary
            Console.WriteLine($"{Name}'s salary is calculated."); // Default implementation to display a message
        }
    }

    // Derived class
    public class FullTimeEmployee : Employee
    {
        // Additional property specific to full-time employees
        public double AnnualSalary { get; set; } // Property to store the annual salary of the full-time employee

        // Overriding the base class method
        public override void CalculateSalary()
        {
            // Override the CalculateSalary method
            Console.WriteLine($"{Name}'s annual salary is {AnnualSalary:C}."); // Display the annual salary using currency format
        }
    }

    // Another derived class
    public class PartTimeEmployee : Employee
    {
        // Additional properties specific to part-time employees
        public double HourlyRate { get; set; } // Property to store the hourly rate of the part-time employee
        public int HoursWorked { get; set; } // Property to store the number of hours worked by the part-time employee

        // Overriding the base class method
        public override void CalculateSalary()
        {
            // Override the CalculateSalary method
            double salary = HourlyRate * HoursWorked; // Calculate the salary based on hourly rate and hours worked
            Console.WriteLine($"{Name}'s salary for {HoursWorked} hours is {salary:C}."); // Display the calculated salary using currency format
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating an instance of FullTimeEmployee
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee
            {
                Name = "Alice", // Assign name to the full-time employee
                EmployeeID = 101, // Assign employee ID to the full-time employee
                AnnualSalary = 60000 // Assign annual salary to the full-time employee
            };

            // Creating an instance of PartTimeEmployee
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee
            {
                Name = "Bob", // Assign name to the part-time employee
                EmployeeID = 102, // Assign employee ID to the part-time employee
                HourlyRate = 20, // Assign hourly rate to the part-time employee
                HoursWorked = 120 // Assign hours worked to the part-time employee
            };

            // Using properties and methods from the base class
            fullTimeEmployee.Work(); // Call the Work method for the full-time employee
            partTimeEmployee.Work(); // Call the Work method for the part-time employee

            // Using overridden methods
            fullTimeEmployee.CalculateSalary(); // Call the overridden CalculateSalary method for the full-time employee
            partTimeEmployee.CalculateSalary(); // Call the overridden CalculateSalary method for the part-time employee
        }
    }

}
