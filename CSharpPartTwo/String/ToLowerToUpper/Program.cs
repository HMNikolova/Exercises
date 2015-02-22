using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToLowerToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Pesho";
            text = text.ToLower();
            Console.WriteLine(text);
            text = text.ToUpper();
            Console.WriteLine(text);
        }
    }
}
