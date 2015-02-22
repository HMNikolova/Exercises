using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static string Reverse(string text)
        {
            //това е по-бавния вариант от долният със StringBuilder
            //string result = string.Empty;
            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    result += text[i];
            //}
            //return result;

            StringBuilder result = new StringBuilder(text.Length);
            //може горния ред и така: var result = new StringBuilder(text.Length);
            for (int i = text.Length - 1; i >= 0; i--)
            {
                result.Append(text[i]);
            }
            return result.ToString();
        }

        static void Main(string[] args)
        {
            string reversed = Reverse("Pesho");
            Console.WriteLine(reversed);
        }
    }
}
