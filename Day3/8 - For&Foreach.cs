/*
In this session we will learn

for, foreach 

The for loop 

A for loop is very similar to while loop. In a while loop we do the initialization at one place, condition check at another place, and modifying the variable at another place, where as for loop has all of these at one place.

Foreach loop

A foreach loop is used to iterate through the items in a collection. for example, foreach loop can be used with arrays or collections such as Arraylist, HashTable and Generics. We will cover collection and generics in a later session.

*/

using System;

class Program
{
    static void Main()
    {
        /*int[] Numbers = new int[3];
        Numbers[0] = 101;  
        Numbers[1] = 102;
        Numbers[2] = 103;

        foreach (int number in Numbers)
        {
            Console.WriteLine(number);
        }*/

        // Using a for loop
        for (int i = 0; i <= 20; i++)
        {
            if(i % 2 == 1)
            Console.WriteLine(i);
        }

       
        
    }
}
