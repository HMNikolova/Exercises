using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.LoopsDemo
{
    class LoopsDemo
    {
        static void Main(string[] args)
        {
            //int i1, i2, i3, i4, i5, i6;
            //  for (i1 = 1; i1 <= 44; i1++)
            //    for (i2 = i1 + 1; i2 <= 45; i2++)
            //      for (i3 = i2 + 1; i3 <= 46; i3++)
            //        for (i4 = i3 + 1; i4 <= 47; i4++)
            //          for (i5 = i4 + 1; i5 <= 48; i5++)
            //            for (i6 = i5 + 1; i6 <= 49; i6++) 
            //              Console.WriteLine("{0} {1} {2} {3} {4} {5}",
            //                i1, i2, i3, i4, i5, i6);//12271512



            //всички четирицифрени числа с условие A+B = C+D (ЩАСТЛИВИ ЧИСЛА)
            for (int a = 1; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    for (int c = 0; c < 10; c++)
                    {
                        int d = a + b - c;
                        if (d < 10 && d > 0)//има някъква грешка
                        {
                            Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);
                        }  
                        //или с четвърти цикъл
                        //for (int d = 0; d < 10; d++)
                        //{
                        //    if (a + b == c + d)
                        //    {
                        //        Console.WriteLine("{0}{1}{2}{3}",a,b,c,d);
                        //    }
                        //}
                    }
                }
            }




            //цикъл с вътрешен break, който брейква и външния цикъл
            //for (int i = 0; i < 5; i++)
            //{
            //    bool toBreak = false;
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (j == 15)
            //        {
            //            toBreak = true;
            //            break;
            //        }
            //    }
            //    if (toBreak)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}


            ////Печат на всички прости числа в интервала [min, max]:
            //int min = int.Parse(Console.ReadLine());
            //int max = int.Parse(Console.ReadLine());

            //for (int i = min; i <= max; i++)
            //{
            //    int divider = 2;
            //    bool isPrime = true;
            //    while (divider < i)
            //    {
            //        if (i % divider == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //        divider++;
            //    }

            //    if (isPrime)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            

            //Печат на всички прости числа в интервала [N, M]:
            //Console.Write("n = ");
            //string numberAsString = Console.ReadLine();
            //int n = int.Parse(numberAsString);
            //Console.Write("m = ");
            //numberAsString = Console.ReadLine();
            //int m = int.Parse(numberAsString);

            //if ((n > 1) && (m > n))
            //{
            //    for (int num = n; num <= m; num++)
            //    {
            //        bool prime = true;
            //        int divider = 2;
            //        int maxDivider = (int)Math.Sqrt(num);
            //        while (divider <= maxDivider)
            //        {
            //            if (num % divider == 0)
            //            {
            //                prime = false;
            //                break;
            //            }
            //            divider++;
            //        }
            //        if (prime)
            //        {
            //            Console.Write("{0} ", num);
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("Invalid range!");
            //}



            //for (int i = 1, sum = 1; i <= 128; i = i * 2, sum += i)
            //{
            //    Console.WriteLine("i={0}, sum={1}", i, sum);
            //}



            //int n = int.Parse(Console.ReadLine());

            //for (int row = 1; row <= n; row++)
            //{
            //    for (int col = 0; col <= row; col++)
            //    {
            //        Console.Write(col + " ");
            //        //ако искаме да принтираме звездичка:
            //        //Console.Write('*');
            //    }

            //    Console.WriteLine();
            //}
        }
    }
}
