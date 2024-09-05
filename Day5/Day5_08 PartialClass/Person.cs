using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_PartialClass1
{
    public partial class Person
    {
        // Properties in the first part of the class
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method in the first part of the class
        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

}
