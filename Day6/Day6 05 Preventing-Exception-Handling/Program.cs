
//Preventing Exception Handling

/*Preventing exception handling in C# generally means designing
 * your code  * to avoid scenarios where exceptions are thrown
 * in the first place.  * While you can't completely 
 * eliminate exceptions  * (since they're a part of the
 * .NET  and are used for signaling errors),
 * you can reduce their frequency and impact through proper design 
 * and programming practices.*/


using System;
using System.Linq.Expressions;

namespace Day6_05_Preventing_Exception_Handling
{
    public class ArithmeticProcessor
    {
        public static void Main()
        {
            Console.WriteLine("Enter the dividend:");
            //try{
            //int dividendInput = Convert.ToInt32(Console.ReadLine());
        //      }
        //Catch() {}
            string dividendInput = Console.ReadLine();
            Console.WriteLine("Enter the divisor:");
            string divisorInput = Console.ReadLine();

            // Validate inputs
            if (!TryParseInput(dividendInput, out int dividend) || !TryParseInput(divisorInput, out int divisor))
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
                return;
            }

            // Perform division with safe checks
            if (TryDivide(dividend, divisor, out int result))
            {
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
        }

        // Method to try parsing the input string to an integer
        private static bool TryParseInput(string input, out int number)
        {
            return int.TryParse(input, out number);
        }

        // Method to perform division safely
        private static bool TryDivide(int dividend, int divisor, out int result)
        {
            if (divisor == 0)
            {
                // Division by zero is not allowed
                result = 0;
                return false;
            }

            // Perform division
            result = dividend / divisor;
            return true;
        }
    }

}
