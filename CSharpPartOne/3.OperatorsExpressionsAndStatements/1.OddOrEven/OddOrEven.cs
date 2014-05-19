//1: Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        Console.Title = "Odd or Even integer";

        Console.WriteLine("Please enter the number:");
        int theNumber = int.Parse(Console.ReadLine());
        if ((theNumber % 2) == 0)
        {
            Console.WriteLine("The number which you entered '{0}' is even.", theNumber); 
        }
        else
        {
            Console.WriteLine("The number which you entered '{0}' is odd.", theNumber); 
        }

    }
}