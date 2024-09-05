/*
When you want to chop the functionality of the class, method, 
interface, or structure into multiple files, then you should use 
partial keyword and all the files are mandatory to be available at 
compile time for creating the final file.
 
 * Advantages : 
With the help of partial classes, multiple developers can work simultaneously 
in the same class in different files.

With the help of a partial class concept, you can split the UI of the 
design code and the business logic code to read and understand the code.

All the parts of the class should be in the same namespace and available 
at compile time to form the final type. All the parts must have same 
access modifier i.e. private, public
 */


namespace Day5_PartialClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30
            };

            person.PrintFullName(); // Output: John Doe
            person.PrintAge();      // Output: Age: 30
        }
    }

}
