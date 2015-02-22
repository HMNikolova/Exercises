using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Now is {0:d.MM.yyyy HH:mm:ss}", now);

            Console.WriteLine("{0:yyyy}", now);
            Console.WriteLine("{0:yyyy - d}", now);
            Console.WriteLine("{0:yyyy - d,M}", now);
            Console.WriteLine("{0:yyyy - d,MM}", now);
            Console.WriteLine("{0:d.MM.yy}", now);
            Console.WriteLine("{0:d.MM.yyyy}", now);
            Console.WriteLine("{0:d.M.yyyy}", now);
            Console.WriteLine("{0:d.MM.yyyy - h:mm:ss}", now);
        }
    }
}
