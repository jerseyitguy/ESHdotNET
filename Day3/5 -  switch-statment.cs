/*
We will learn 

switch statement
Break statement
goto statement(Always Avoided)

switch(Number)
{
case 10:
case 20:
case 30:
  Console.Writeline("Your number is {0}",Number);
  break;
  default:
    Console.Writeline("Your number is not 10, 20 &30");
    break;
}

Note: Case statements. with no code in-between. creates a single case for multiple values.A case without any code will automatically fall through to the next case. In this example, case 10 and cases 20 will fall through and execute code for case 30.

break statement: If break statement is used inside a switch statement, the control will leave the switch statement.

goto statement: You can either jump to another case statement, or to a specific label.

Warning: Using goto is bad programming style.vWe can should avoid goto.
*/

using System;

class Program
{
    static void Main()
    {
        Start:
        int TotalCoffeeCost = 0;
        Console.WriteLine(" Please select your coffee 1 -  Small, 2 - Medium, 3 - Large");
        int UserChoice = int.Parse(Console.ReadLine());

        switch (UserChoice)
        {
            case 1:
                TotalCoffeeCost += 1;
                break;
            case 2:
                TotalCoffeeCost += 2;
                break;
            case 3:
                TotalCoffeeCost += 3;
                break;
            default:
                Console.WriteLine("Your choice  {0} is invalid.", UserChoice);
                goto Start;
        }
        Console.WriteLine("Do you want to buy another coffee Yes Or NO");
        string userdecison = Console.ReadLine();

        Decide:
        switch (userdecison)
        {
            case "Yes":
                goto Start;
            case "No":
                break;
            default:
                Console.WriteLine("Your choice {0} is invalid. Please try agian ");
                goto Decide;
        }


        Console.WriteLine("Thank you for shopping with us");
        Console.WriteLine("Bill amount = {0}",TotalCoffeeCost);
    }
}

