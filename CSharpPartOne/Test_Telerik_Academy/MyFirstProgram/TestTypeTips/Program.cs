using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTypeTips
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3; 
            int b = 5;

            Console.WriteLine(Convert.ToString(a, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(a <<= 1, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(a <<= 2, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(a >>= 1, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(a <<= 1, 2).PadRight(32));

        }
    }
}
