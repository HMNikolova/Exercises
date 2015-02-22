using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToStringToFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            //var currentDate = DateTime.Now;//обект, който си пази текущия ден, дата и т.н.
            //Console.WriteLine(currentDate.ToString());//ToString го прави разбираем за хората

            //Console.WriteLine("{0:C}", 5);//валута
            //Console.WriteLine("{0:F2}", 5);//залепя 2 нули
            //Console.WriteLine("{0:P}", 0.05);//процент
            //същото може да го правим със стрингове

            int number = 42;
            string text = number.ToString("C");
            Console.WriteLine(text);

            string text1 = number.ToString("F2");
            Console.WriteLine(text1);

            string text2 = string.Format("{0:F2}", 45);
            Console.WriteLine(text2);

            string text3 = string.Format("{0:P}", 0.05);
            Console.WriteLine(text3);

            string text4 = number.ToString("E");//за много малки и много големи числа 
            Console.WriteLine(text4);

            string text5 = number.ToString("X");//превръща в шестнадесетична бройна система
            Console.WriteLine(text5);

            string template = "{0} {1} {2}";
            string text6 = string.Format(template, 45, 56, 78);//вмъкване на нещо в текст
            Console.WriteLine(text6);

            string template1 = "{0,10}";//отпечатва 10 символа преди 45
            string text7 = string.Format(template1, 45);
            Console.WriteLine(text7);

            string template2 = "{0,-10:F2}";//отпечатва 45 и 10 празни символа след това, а F2 ще му сложи 2 нули
            string text8 = string.Format(template2, 45);
            Console.WriteLine(text8 + "!");
            //аналогичен вариант на последния е
            string template3 = "{0,-10:F2}";
            string text9 = string.Format(template3, 45);
            Console.WriteLine("{0,-10:F2}!", 45);
        }
    }
}
