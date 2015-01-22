using System;
using System.Text;
using System.Threading;
using System.Globalization;

namespace Encoding
{
    class Encoding
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            string str = "Това е килица";
            Console.WriteLine(str);
            //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            //double num = double.Parse(Console.ReadLine());
            //Console.WriteLine(num);//зависимост от настройките изкарва , или .
            Console.WriteLine("{0:C}",123.45);
        }
    }
}
