/*Difference between Convert. ToString() handles null, while ToString() doesn't and throws a Null Reference exception 

Depending on the type of the application, architecture and what you are trying to achieve, 
you choose one over the  other
*/

using System;

namespace Day5_06_DifferConvertToSting_ToString
{

    public class Program
    {
        public static void Main()
        {
            int num = 42;

            // Using ToString()
            string str1 = num.ToString();
            Console.WriteLine("ToString() output: " + str1); // Output: "42"

            // Using Convert.ToString()
            string str2 = Convert.ToString(num);
            Console.WriteLine("Convert.ToString() output: " + str2); // Output: "42"

            // Null handling
            string nullStr = null;

            // string str3 = nullStr.ToString(); // Uncommenting this will throw a NullReferenceException
            string str4 = Convert.ToString(nullStr);
            Console.WriteLine("Convert.ToString() on null: " + (str4 == null ? "null" : str4)); // Output: "null"
        }
    }

}
