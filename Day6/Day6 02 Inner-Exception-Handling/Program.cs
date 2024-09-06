/*Inner Exception
The innerException property returns the exception instance that
caused the curent exception.
To retain the original exception pass it as a parameter to 
the constructor, of the current exception.
Always check if inner exceptions is not null before accessing 
any property of the inner exception object, else, you may get
Null reference Exception .
To get the type of InnerException use GetType() method
*/
using System;


namespace Day6_02_Inner_Exception_Handling
{
    class InnerExceptionExample
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter First number:");
                int FN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second number:");
                int SN = Convert.ToInt32(Console.ReadLine());

                try
                {
                    // Attempt to divide the numbers
                    int Result = FN / SN;
                    Console.WriteLine("Result: {0}", Result);
                }
                catch (DivideByZeroException ex)
                {
                    // Wrap the DivideByZeroException in a new Exception with a custom message
                   throw new ArithmeticException("Attempted to divide by zero.", ex);
                  //  throw new ArithmeticException("Attempted to divide by zero.");
                }
            }
            catch (FormatException ex)
            {
                // Handle invalid input and wrap the original exception as an inner exception
                Console.WriteLine("Input was not a valid number.");
                Console.WriteLine("Detailed Error: {0}", ex.Message);
            }
            catch (ArithmeticException ex)
            {
                // Handle arithmetic exceptions (like divide by zero)
                Console.WriteLine("Arithmetic error occurred: {0}", ex.Message);

                // Check for inner exception and display details if it exists
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: {0}", ex.InnerException.Message);
                }
            }
            catch (Exception ex)
            {
                // Catch any other unforeseen exceptions
                Console.WriteLine("An unexpected error occurred: {0}", ex.Message);
            }
        }
    }

}
