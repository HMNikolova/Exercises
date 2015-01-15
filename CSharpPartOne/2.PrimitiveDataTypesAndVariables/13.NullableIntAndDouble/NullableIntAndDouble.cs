//12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? intVar = null;
        double? doubleVar = null;

        Console.WriteLine("Int with value null = {0}", intVar);
        Console.WriteLine("Double with value null = {0}", doubleVar);

        intVar = 5;
        doubleVar = 5.5;

        Console.WriteLine("New int value: {0}", intVar.GetValueOrDefault());
        Console.WriteLine("New double value: {0}", doubleVar.GetValueOrDefault());
    }
}

