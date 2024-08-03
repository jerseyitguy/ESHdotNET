using System;

namespace App
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a Number");
            string NumString = Console.ReadLine();
            int Num;
            Int32.TryParse(NumString, out Num);
            if (Num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            if (Num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            if (Num % 3 == 0 && Num % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
             if (Num % 3 != 0 && Num % 5 != 0)
            {
                Console.WriteLine(Num);
            }
        }
    }
}
