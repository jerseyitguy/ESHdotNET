
/*
We will learn

while loop 
do while loop 
Difference between while loop and do while loop


The While Loop

1. While loop checks the conditions first.
2. If the condition is true, statements with in the loop are executed.
3. This process is repeated as long as the condition evaluates to  true

Note: Don't forget to update the variable participating the condition, so the loop can end, at some point

Do While Loop

1. A do loop checks its condition at the end of the loop.
2. This means that the do loop is guaranteed to execute at least one time.
3. Do loops are used to present a menu to the user

Difference - While & do while

1. While loop checks the condition at the beginning where as do while loop checks the condition at the end of the loop.
2. Do loop is guaranteed to execute at least once, where as while loop is not.
*/
using System;

class Program
{

    static void Main()
    {
        Console.WriteLine("Please enter your target ");
        int UserTarget = int.Parse(Console.ReadLine());

        int start = 0;

        while(start <= UserTarget)
        {
            Console.WriteLine(start + " ");
            start = start + 2;
        }
    }
}