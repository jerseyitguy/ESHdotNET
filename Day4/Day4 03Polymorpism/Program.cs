// Polymorphism in C#
// Overriding virtual methods

/*
 * What is polymorphism?
 * Polymorphism is one of the primary pillars of Object Oriented Programming.
 * Polymorphism allows you to invoke derived class methods through a base class
 * reference during runtime.
 * In the base class, a method is declared virtual, and in the derived class, we override the same method.
 * The virtual keyword indicates that the method can be overridden in any derived class.
 */

namespace Day4_03Polymorpism
{
    public class Employee
    {
        // Fields to store first and last names
        public string FirstName = "Shirley";
        public string LastName = "John";

        // Virtual method that can be overridden in derived classes
        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    // Derived class PartTimeEmployee inheriting from Employee
    public class PartTimeEmployee : Employee
    {
        // Overriding the virtual method from the base class
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " Part time");
        }
    }

    // Derived class FullTimeEmployee inheriting from Employee
    public class FullTimeEmployee : Employee
    {
        // Overriding the virtual method from the base class
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " Full Time");
        }
    }

    // Derived class TemporaryTimeEmployee inheriting from Employee
    public class TempooraryTimeEmployee : Employee
    {
        // Overriding the virtual method from the base class
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " Temporary");
        }
    }

    // Main program class
    public class Program
    {
        public static void Main()
        {
            // Creating an array of Employee references
            // Employee[] employees = new Employee[4];
            Employee[] employees =
            [
                // Initializing the array with different types of Employee objects
                new Employee(),
                new PartTimeEmployee(),
                new FullTimeEmployee(),
                new TempooraryTimeEmployee(),
            ];

            // Iterating through the array and calling PrintFullName on each object
            foreach (Employee e in employees)
            {
                // Polymorphism allows the correct method to be called based on the actual object type
                e.PrintFullName();
            }
        }
    }

}
