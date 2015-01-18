using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSequenceOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            byte counter = 10;

            Console.WriteLine("Enter the starting number of the sequence: ");
            int startNumber = int.Parse(Console.ReadLine());

            for (int i = startNumber; i < startNumber + counter; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(-i + ", ");
                }
            }
        }
    }
}
