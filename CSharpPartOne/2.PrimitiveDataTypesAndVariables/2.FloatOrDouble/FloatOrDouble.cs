// 2. Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?

using System;
using System.Collections.Generic;

class FloatOrDouble
{
    static void Main()
    {
        double doubleNum = 34.567839023d;
        float floatNum = 12.345f;
        double secondDoubleNum = 8923.1234857;
        float secondFloatNum = 3456.091f;

        Console.WriteLine("Values who can be assigned to float are: {0} and {1}", floatNum, secondFloatNum);
        Console.WriteLine("Values who can be assigned to double are: {0} and {1}", doubleNum, secondDoubleNum);
    }
}
