using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CompanyInfo
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter number: ");
            double secondNumber = double.Parse(Console.ReadLine());
           


            //Console.Write("Enter number: ");
            //double first = double.Parse(Console.ReadLine());

            //Console.Write("Enter number: ");
            //double second = double.Parse(Console.ReadLine());
            double max = Math.Max(firstNumber, secondNumber);
            Console.WriteLine("The greater number is: {0}\n", max);

            //double absMax = ((first + second + Math.Abs(first - second)) / 2);
            //Console.WriteLine("The greater number is: {0}", absMax);
        }
    }
}
