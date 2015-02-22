using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "pesho gosho";
            string subStr = text.Substring(6);//изкарва само gosho
            //string subStr = text.Substring(6, 3);//така започва от 6 символ и казва дай ми следващите 3 символа 
            Console.WriteLine(subStr);
        }
    }
}
