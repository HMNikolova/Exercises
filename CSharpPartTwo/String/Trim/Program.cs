using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trim - зачиства всички боклуци, той реже само отпред и отзад не вътре в текста
            //string text = "            Pesho     ";
            //text = text.Trim();
            //Console.WriteLine(text + "a");
            //text = text.TrimStart();
            //Console.WriteLine(text + "a");
            //text = text.TrimEnd();
            //Console.WriteLine(text + "a");

            //string text = "aaa            Pesho     ";
            //text = text.Trim('a');
            //Console.WriteLine(text + "b");

            string text = "cccaaa            Pesho    aaaccc ";
            text = text.Trim('a', 'b', 'c', ' ');
            Console.WriteLine(text + "b");
        }
    }
}
