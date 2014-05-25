/*8: Write an expression that checks for given point (x, y) if it is 
 within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).*/

using System;

class CircleAndRectangle
{
    static void Main(string[] args)
        {
            Console.WriteLine("Enter \"x\" and \"y\" coordinates of the point: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int r = 3;
            int rTop = 1;
            int rLeft = -1;
            int rWidth = 6;
            int rHeight = 2;
            int rectangeUpperSide = rTop;
            int rectangeLowerSide = rTop - rHeight;
            int rectangeLeftSide = rLeft;
            int rectangeRightSide = rLeft + rWidth;

            bool withinTheRectangle = (x <= rectangeUpperSide) && (x >= rectangeLowerSide) && (y >= rectangeLeftSide) && (y <= rectangeRightSide);
            bool withinTheCircle = x * x + y * y <= r * r;
            if (withinTheRectangle && withinTheCircle)
            {
                Console.WriteLine("The point is within the circle and the rectangle.");
            }
            else
            {
                if (withinTheCircle && !withinTheRectangle)
                {
                    Console.WriteLine("The point is within the circle and outside the rectangle.");
                }
                else
                {
                    if (!withinTheCircle && withinTheRectangle)
                    {
                        Console.WriteLine("The point is outside the circle and within the rectangle.");
                    }
                    else
                    {
                        Console.WriteLine("The point is outside the circle and the rectangle.");
                    }
                }
            }
        }
    }
