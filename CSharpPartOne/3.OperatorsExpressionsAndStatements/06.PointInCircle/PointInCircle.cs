/*6: Write an expression that checks if given point (x,  y) is within a circle K(O, 5).*/

using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter point coordinates (x,y) to check if is inside in the circle K(O, 5):");

        Console.WriteLine(); //empty row

        Console.Write("Width x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Height y = ");
        double y = double.Parse(Console.ReadLine());
        double circleRadius = 5; // by default circle radius is "5"

        Console.WriteLine(new string('-', 66)); // print 66 "-" symbols like devider

        if ((x * x + y * y) <= circleRadius * circleRadius) // the Pythagorean theorem " a2 + b2 = c2"
        {
            Console.WriteLine("Point with coordinates ({0}, {1}) is inside in the circle K(O, 5).", x, y);
        }
        else
        {
            Console.WriteLine("Point with coordinates ({0}, {1}) is not inside in the circle K(O, 5).", x, y);
        }

        Console.WriteLine(new string('-', 66)); // print 66 "-" symbols like devider
    }
}