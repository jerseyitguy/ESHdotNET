using System;
namespace Operators
{
    class Program
    {
        public static void Main()
        {
            // Assignment Operator example
            // Single = is the assignment operator
            int i = 10;
            bool b = true;

            // For dividing 2 numbers we can use either
            // % or / operators
            int numerator = 10;
            int denominator = 2;

            // Arithmentic operator / returns quotient
            int quotient = numerator / denominator;
            Console.WriteLine("Quotient = {0}", quotient);

            // Arithmentic operator % returns remainder
            int remainder = numerator % denominator;
            Console.WriteLine("Remainder = {0}", remainder);

            // To compare if 2 numbers are
            // equal use comparison operator ==
            int number = 10;
            if (number == 10)
            {
                Console.WriteLine("Number is equal to 10");
            }

            // To compare if 2 numbers are not
            // equal use comparison operator !=
            if (number != 5)
            {
                Console.WriteLine("Number is not equal to 5");
            }

            // When && operator is used all the conditions must
            // be true for the code in the "if" block to be executed
            int number1 = 10;
            int number2 = 20;

            if (number1 == 10 && number2 == 20)
            {
                Console.WriteLine("Both conditions are true");
            }

            // When || operator is used the code in the "if" block
            // is excuted if any one of the condition is true
            number1 = 10;
            number2 = 21;

            if (number1 == 10 || number2 == 20)
            {
                Console.WriteLine("Atleast one of the condition is true");
            }
        }
    }
}