// Enums in C#
//why Enums

//Enums are strongly typed constants.

/*If a program uses set of integral numbers, consider replacing them 
 * with enums. Otherwise the program becomes less.*/
//Readable 
// Maintainable

using System;

namespace Day5_03_bEnumExamples
{
    public class Enums
    {

        public static void Main()
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer
            {
                Name = "Mark",
                Gender = Gender.Male
            };

            customers[1] = new Customer
            {
                Name = "Marry",
                Gender = Gender.Female

            };

            customers[2] = new Customer
            {
                Name = "Sam",
                Gender = Gender.Unknown
            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name = {0}  Gender = {1}", customer.Name, GetGender(customer.Gender));
            }
        }
        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "invalid data detected";

            }

        }

    }

    public enum Gender
    {

        Unknown,
        Male,
        Female

    }

    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }


    }
}
