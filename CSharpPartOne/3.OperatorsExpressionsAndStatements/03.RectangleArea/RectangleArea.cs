﻿using System;

    class RectangleArea
    {
        static void Main(string[] args)
        {
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            Console.WriteLine("The area of the rectangle is: {0}",area);
        }
    }


