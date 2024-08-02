using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Number");
            int Usernumber = int.Parse(Console.ReadLine());
            if (Usernumber == 1)
            {
                Console.WriteLine("Dear User Your Number is 1");
            }
            else if (Usernumber == 2)
            {
                Console.WriteLine("Dear User Your Number is 2");
            }
            else if (Usernumber == 3)
            {
                Console.WriteLine("Dear User Your Number is 3");
            }
            else if (Usernumber == 4)
            {
                Console.WriteLine("Dear User Your Number is 4");
            }
            else if (Usernumber == 5)
            {
                Console.WriteLine("Dear User Your Number is 5");
            }
            else
            {
                Console.WriteLine("Dear User Your Number is Not Between 1-5");
            }
            Console.ReadKey();

        }
    }
}