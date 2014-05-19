/*3. Write a program that safely compares floating-point numbers with precision of 0.000001.Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true */

using System;
using System.Collections.Generic;

class CompareFloatingPointNumers
{
    static void Main()
    {
        Console.Title = "Compare";

        //create new string who writing in console 52 "-" (minus) like devider
        Console.WriteLine(new string('-', 52));

        decimal FirstNumber = Math.Round(5.3M, 6);
        decimal SecondNumber = Math.Round(6.01M, 6);
        Console.WriteLine("First number is: {0}; Second number is:{1}", FirstNumber, SecondNumber);
        Console.WriteLine("Is equal is: {0}", (FirstNumber == SecondNumber));

        Console.WriteLine(new string('-', 52));

        decimal ThirdNumber = Math.Round(5.00000001M, 7);
        decimal FourthNumber = Math.Round(5.00000003M, 7);
        Console.WriteLine("First number is: {0}; Second number is:{1}", ThirdNumber, FourthNumber);
        Console.WriteLine("Is equal is: {0}", (ThirdNumber == FourthNumber));

        Console.WriteLine(new string('-', 52));
    }
}
