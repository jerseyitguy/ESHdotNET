
//Exception handling Abuse
//Exception handling abuse" typically refers to improper or excessive use of
//exceptions
//in
//a way that can lead to poor program design, reduced performance, or other
//issues. 

/*
// Bad practice directly writing Catch block with Exception base class
try
{
    // Some code
}
catch (Exception ex)
{
    // Handling any exception
    Console.WriteLine(ex.Message);
}

// Abuse
try
{
    // Some code
}
catch (FileNotFoundException ex)
{
    // Handle file not found specific case
    Console.WriteLine("File not found: " + ex.Message);
}
catch (ArgumentException ex)
{
    // Handle argument exception
    Console.WriteLine("Invalid argument: " + ex.Message);
}
catch (Exception ex)
{
                // Catch any other unforeseen exceptions
                Console.WriteLine("An unexpected error occurred: {0}", ex.Message);
}

*/



namespace Day6_04_Exception_Handling_Abuse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
