using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Cultures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Thread.CurrentThread.CurrentCulture);//текущата култура
            //Console.WriteLine(DateTime.Now);
            //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");//с каква култура да работи програмата
            //Console.WriteLine(System.Threading.Thread.CurrentThread.CurrentCulture);
            //Console.WriteLine(DateTime.Now);

            //int number = 42;
            //CultureInfo culture = new CultureInfo("fr-CA");
            //string s = number.ToString("C", culture);
            //Console.WriteLine(s);//резултат 42 долара

            //string str = "3.14";
            //Thread.CurrentThread.CurrentCulture =
            //  CultureInfo.InvariantCulture;
            //float f = float.Parse(str);
            //Console.WriteLine(f);//резултат 3.14

            string dateStr = "25.07.2011";
            DateTime date = DateTime.ParseExact(dateStr,
              "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date);



            //подаваме стринга, който искаме да парснеме, а CultureInfo.InvariantCulture означава да не се съобразява с никакви култури, а да ги парсва по този начин
            //DateTime parsed = DateTime.ParseExact("17.02.2015", "dd.MM.yy", CultureInfo.InvariantCulture);
            //Console.WriteLine(parsed.Year);
        }
    }
}
