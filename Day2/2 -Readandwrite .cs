
//Please note that C# is case sensitive language.

using System;
class Program
{
    static void Main()
    {
        // Prompt the user for his name
        Console.WriteLine("Please enter your name");
        // Read the name from console
        string UserName = Console.ReadLine();
        // Concatenate name with hello word and print
        Console.WriteLine("Hello " + UserName);

        //Placeholder syntax to print name with hello word 
        //Console.WriteLine("Hello {0}", UserName);
    }
}