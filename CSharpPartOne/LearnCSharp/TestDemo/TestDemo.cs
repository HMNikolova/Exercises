using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TestDemo
{
    class TestDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer number: ");
            int firstInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer number: ");
            int secondInt = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = firstInt; i <= secondInt; i++)
            {

                if (i % 5 == 0)
                {
                    count++;
                    Console.Write("{0}, ", i);
                }
            }
            Console.WriteLine("there are {0} numbers between {1} and {2}, that the reminder of their division by 5 is 0"
                                , count, firstInt, secondInt);
        }

            //Console.Write("Enter int number: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Enter double number: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Enter double number: ");
            //double c = double.Parse(Console.ReadLine());

            //Console.Write("|{0,-10}|",a.ToString("X"));
            //Console.Write("{0}|", Convert.ToString(a, 2).PadLeft(10, '0'));
            //Console.Write("{0,10:0.00}|",b);
            //Console.WriteLine("{0,-10:0.000}|", c);

            //Console.Write("a = ");
            //double a = double.Parse(Console.ReadLine()); //2
            //Console.Write("b = ");
            //double b = double.Parse(Console.ReadLine()); //5
            //Console.Write("c = ");
            //double c = double.Parse(Console.ReadLine());//-3
            ////5*5      4 * 2 * -3
            //double discriminant = (b * b) - (4 * a *33 c);
            //if (discriminant > 0)
            //{
            //    double x1 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            //    double x2 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
            //    Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
            //}
            //else if (discriminant == 0)
            //{
            //    double x1Andx2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            //    Console.WriteLine("x1 = x2 = {0}", x1Andx2);
            //}
            //else if (discriminant < 0)
            //{
            //    Console.WriteLine("No real roots");
            //}


            //string[] a = Console.ReadLine().Split(' ');
            //double sum = 0;
            //for (int i = 0; i < a.Length; i++)
            //{
            //    sum += Convert.ToDouble(a[i]);               
            //}
            //Console.WriteLine(sum);

         
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //double num = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter {0} numbers", num);
            //double sum = 0;
            //for (int i = 1; i <= num; i++)
            //{
            //    double numbers = double.Parse(Console.ReadLine());
            //    sum = sum + numbers;
            //}
            //Console.WriteLine("sum is {0}", sum);

            //Console.Write("Enter int number: ");
            //BigInteger a = BigInteger.Parse(Console.ReadLine());
            //BigInteger firstNum = 0;
            //BigInteger secondNum = 1;
            //BigInteger sum;
            //for (int i = 0; i < a; i++)
            //{
            //    Console.WriteLine("{0}", firstNum);
            //    sum = firstNum + secondNum;
            //    firstNum = secondNum;
            //    secondNum = sum;
            //}
        //}
    }
}
