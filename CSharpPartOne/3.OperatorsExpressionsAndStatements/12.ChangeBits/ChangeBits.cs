﻿/*12: We are given integer number n, value v (v=0 or 1) and a position p. 
 * Write a sequence of operators that modifies n to hold the value v at the 
 * position p from the binary representation of n.
 * 
 * Example: n = 5 (00000101), p=3, v=1  13 (00001101)
 * n = 5 (00000101), p=2, v=0  1 (00000001)
*/

using System;

    class ChangeBits
    {
        static void Main()
        {
            Console.Write("Please enter the number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Please enter the value: ");
            int value = int.Parse(Console.ReadLine());
            Console.Write("Please enter the bit position: ");
            int position = int.Parse(Console.ReadLine());
            if (value == 0)
            {
                int mask = ~(1 << position);
                int result = number | mask;
                Console.WriteLine(result);
            }
            else if (value == 1)
            {
                int mask = 1 << position;
                int result = number | mask;
                Console.WriteLine(result);
            }
            else 
            {
                Console.WriteLine("Your program sucks!");
            }
        }
    }

