using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            int b; 
            string bas = Console.ReadLine();
            b = int.Parse(bas);
            int c; 
            string bast = Console.ReadLine();
            c = int.Parse(bast);
            Console.WriteLine(Math.Pow(b, c));
        }
    }
}
