/* Method overloading in C# is a feature of object-oriented programming that allows 
 * a class to have multiple methods with the same name, but with different parameters 
 * (i.e., different type, number, or order of parameters). 
   The correct method to call is determined at compile time based on the method 
signature (the method's name and parameter list). */

using System; // Using directive for the System namespace


namespace Day4_05MethodOverLoading
{
    // Main program class
    public class Program
    {
        // Main method: the entry point of the program
        public static void Main()
        {
            // Creating an instance of the Program class to call instance methods
            //Program program = new Program();

            // Calling the overloaded Add methods with different parameters
            Add(10, 20);          // Calls the method with two int parameters
            Add(10, 20.5f);       // Calls the method with int and float parameters
            Add(10.5f, 20.5f);    // Calls the method with two float parameters
        }

        // Method overloading: Add method with two int parameters
        // This method takes two integers and prints their sum
        public static void Add(int FN, int SN)
        {
            // Calculate and print the sum of two integers
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        // Method overloading: Add method with int and float parameters
        // This method takes one integer and one float and prints their sum
        public static void Add(int FN, float SN)
        {
            // Calculate and print the sum of an integer and a float
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        // Method overloading: Add method with two float parameters
        // This method takes two floats and prints their sum
        public static void Add(float FN, float SN)
        {
            // Calculate and print the sum of two floats
            Console.WriteLine("Sum = {0}", FN + SN);
        }
    }

}
