/*Exception Handling
An exception is an unforeseen error that occurs when a program
is running. Releasing System Resources
We use try, catch and family blocks for exception handling.
try- The code that can possibly cause an exception will be in 
the try block.
catch- Handles the exception.
Finally- Clean and free resources that the class was holding onto
during the program execution. Finally block is optional
*/

using System;
using System.IO;

namespace Day6_01ExceptionHandling
{
    class Program
    {
        public static void Main()
        {
            StreamReader? streamReader = null;
            try
            {
                // Attempt to open the file using a StreamReader
                // The path provided must exist, otherwise, a FileNotFoundException will be thrown
                 streamReader = new StreamReader("D:\\Zach\\C# Training\\Day 6\\Test1.txt");

                // Read the entire content of the file and print it to the console
                // The ReadToEnd method reads all characters from the current position to the end of the file
                Console.WriteLine(streamReader.ReadToEnd());

                // Close the StreamReader to release the file resource
                // Closing the StreamReader is essential to avoid file locks and free up resources
               // streamReader.Close();
            }
            catch (FileNotFoundException ex)
            {
                // This block handles the situation where the
                // file specified is not found
                // ex.FileName provides the name of the file that caused the exception
                              
                Console.WriteLine("Please check if the file {0} exists", ex.FileName);
                Console.WriteLine();
                if (ex.StackTrace != null)
                {
                    Console.WriteLine("Print StackTrace {0}", ex.StackTrace);
                }           
            }
          
            catch (Exception ex)
            {
                // This block catches any other exceptions that are not specifically caught by the previous catch blocks
                // ex.Message gives a description of the exception
                Console.WriteLine(ex.Message);
                if (ex.StackTrace != null)
                {
                    Console.WriteLine("Print StackTrace", ex.StackTrace);
                }
            }
            finally
            {
                // The finally block executes regardless of whether an exception was thrown or not
                // It is often used for cleanup code, like closing files, releasing resources, etc.
                if (streamReader == null)
                {
                }
                else
                    streamReader.Close(); //Need to discuss
                Console.WriteLine("File handling block completed.");
            }
        }
    }

}
