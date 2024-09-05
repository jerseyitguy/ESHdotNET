/*Why Properties
Marking the class fields public and exposing to the external world is bad,
as you will not have control over what gets assigned and returned.*/


using System;


namespace Day5_01WhyProperties
{
    public class Student
    {
        // Private fields to store student details
        private int _id;        // Field to store the student's ID
        private string _Name;   // Field to store the student's name
        private int _passMark = 35;  // Field to store the pass mark (default is 35)

        // Public method to get the pass mark
        public int GetPassMark()
        {
            // Return the value of the _passMark field
            return this._passMark;
        }

        // Public method to set the student's name
        public void SetName(string Name)
        {
            // Check if the provided name is null or empty
            if (string.IsNullOrEmpty(Name))
            {
                // If the name is invalid, throw an exception with a relevant message
                throw new Exception("Name cannot be null or empty");
            }
            // If the name is valid, assign it to the _Name field
            this._Name = Name;
        }

        // Public method to get the student's name
        public string GetName()
        {
            // If the _Name field is null or empty, return "No Name"; otherwise, return the actual name
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
        }

        // Public method to set the student's ID
        public void SetId(int Id)
        {
            // Check if the provided ID is less than or equal to 0
            if (Id <= 0)
            {
                // If the ID is invalid, throw an exception with a relevant message
                throw new Exception("Student ID cannot be negative");
            }
            // If the ID is valid, assign it to the _id field
            this._id = Id;
        }

        // Public method to get the student's ID
        public int GetId()
        {
            // Return the value of the _id field
            return this._id;
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Create a new Student object
            Student C1 = new Student();

            // Set the student's ID to 101
            C1.SetId(101);

            // Set the student's name to "Mark"
            C1.SetName("Mark");

            // Display the student's ID using the GetId method
            Console.WriteLine("Student Id = {0}", C1.GetId());

            // Display the student's name using the GetName method
            Console.WriteLine("Student Name = {0}", C1.GetName());

            // Display the pass mark using the GetPassMark method
            Console.WriteLine("PassMark = {0}", C1.GetPassMark());
        }
    }

}
