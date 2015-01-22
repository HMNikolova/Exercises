using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    class TryParse
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int num;
            bool isParsable = int.TryParse(str, out num);
            if (isParsable)
            {
                Console.WriteLine(num * 2);
            }
            else
            {
                Console.WriteLine("{0} is not a valid number", str);
            }
        }
    }
}
