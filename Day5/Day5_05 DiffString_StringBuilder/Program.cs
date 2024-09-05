
using System.Text;

namespace Day5_05_DiffString_StringBuilder
{
    public class StringExample
    {
        public static void Main()
        {
            // Start timer to measure performance
            var watch = System.Diagnostics.Stopwatch.StartNew();

            // Initializing an empty string
            string result = "";

            // Concatenating numbers from 1 to 10000
            for (int i = 1; i <= 10000; i++)
            {
                result += i.ToString() + ", ";
            }

            // Stop the timer
            watch.Stop();

            // Output the first 100 characters and the time taken
            Console.WriteLine("Using System.String: ");
            Console.WriteLine(result.Substring(0, 100) + "..."); // Display only the first 100 characters
            Console.WriteLine($"Time taken: {watch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Length of final string: {result.Length}");
        }
    }
}
