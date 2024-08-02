using System;
namespace ConsoleApplication1
{
    class Program
    {
        public static void Main()
        {
            // Displaying double quotes in c#
            string Name = "\"Pragim\"";
            Console.WriteLine(Name);

            // Displaying new line character in c#
            Name = "One\nTwo\nThree";
            Console.WriteLine(Name);

            // Displaying new line character in c#
            Name = "c:\\Pragim\\DotNet\\Training\\Csharp";
            Console.WriteLine(Name);

            // C# verbatim literal
            Name = @"c:\Pragim\DotNet\Training\Csharp";
            Console.WriteLine(Name);
        }
    }
}