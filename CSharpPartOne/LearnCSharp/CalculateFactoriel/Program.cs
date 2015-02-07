using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFactoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberN;
            do
            {
                Console.Write("Enter a integer number N (1-20): ");
                numberN = int.Parse(Console.ReadLine()); ;
                if (numberN <= 0)
                {
                    Console.WriteLine("N must be greater 0");
                }
                if (numberN > 20)
                {
                    Console.WriteLine("N must be smaller 21");
                }
            }
            while ((numberN < 1) || (numberN > 20));
            for (int i = 0; i < numberN; i++)
            {
                for (int j = 1 + i; j <= numberN + i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }

            //Console.WriteLine("Enter value of N: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter value of K: ");
            //int k = int.Parse(Console.ReadLine());

            //BigInteger fact1 = 1;
            //BigInteger fact2 = 1;

            //if (1 < k && n > k && n < 100)
            //{
            //    for (int i = k + 1; i <= n; i++)
            //    {
            //        fact1 *= i;
            //    }
            //    for (int j = 1; j <= (n - k); j++)
            //    {
            //        fact2 *= j;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}
            //BigInteger result = fact1 / fact2;
            //Console.WriteLine(result);

            //int n = int.Parse(Console.ReadLine());
            //int k = int.Parse(Console.ReadLine());
            //BigInteger sum = 1;
            //if (n<=100 && k>1)
            //{
            //    for (int i = k + 1; i <= n; i++)
            //    {
            //        sum *= i;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Input!");
            //}
            //Console.WriteLine(sum);
        }
    }
}
