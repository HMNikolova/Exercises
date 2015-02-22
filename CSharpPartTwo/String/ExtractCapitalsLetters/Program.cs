using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractCapitalsLetters
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string reversed = Reverse("PeSho");
            Console.WriteLine(reversed);

            Console.WriteLine(ExtractCapitals("PeSho"));
        }

        static string ExtractCapitals(string text)//метода връща само главните букви
        {
            var result = new StringBuilder(text.Length);
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))//или (text[i] >= 'A' && text[i] <='Z')
                {
                    result.Append(text[i]);
                }
            }
            return result.ToString();
        }

        static string Reverse(string text)
        {
            StringBuilder result = new StringBuilder(text.Length);
            for (int i = text.Length - 1; i >= 0; i--)
            {
                result.Append(text[i]);
            }
            return result.ToString();
        }
    }
}
