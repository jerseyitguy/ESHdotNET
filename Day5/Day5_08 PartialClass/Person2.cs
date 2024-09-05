using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_PartialClass1
{
    public partial class Person
    {
        // Additional property in the second part of the class
        public int Age { get; set; }

        // Additional method in the second part of the class
        public void PrintAge()
        {
            Console.WriteLine($"Age: {Age}");
        }
    }
}
