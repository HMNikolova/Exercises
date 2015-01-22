using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
            string[] inputArr = new string[10];
            string input;
            while ((input = Console.ReadLine()) != null)
            {
                inputArr[0] = input;
            }
            Console.WriteLine("End");
        }
    }
}
