// Enums in C#
//why Enums

//Enums are strongly typed constants.

/*If a program uses set of integral numbers, consider replacing 
 * them with enums. Otherwise the program becomes less.*/
//Readable 
// Maintainable

using System;

namespace Day5_03_aEnumExamples
{
    public class Enums
    {

        public static void Main()
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer
            {
                Name = "Mark",
                Gender = 1
            };

            customers[1] = new Customer
            {
                Name = "Marry",
                Gender = 2

            };

            customers[2] = new Customer
            {
                Name = "Sam",
                Gender = 3
            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name = {0}  Gender = {1}", customer.Name, GetGender(customer.Gender));
            }
        }
        public static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "invalid data detected";

            }

        }

    }



    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }


    }
}
