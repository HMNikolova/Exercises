using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case-insensitive - не го интересува буквата дали е малка или голяма
            //int result = string.Compare(str1, str2, true);//при true няма значение дали ще сравняваме малки или големи букви
            // result == 0 if str1 equals str2
            // result < 0 if str1 is before str2
            // result > 0 if str1 is after str2

            //Case-sensitive
            //string.Compare(str1, str2, false);//при false има значение дали ще сравняваме малки и големи букви

            int result = string.Compare("abc", "ABC", true);
            Console.WriteLine(result);

            int results = string.Compare("abc", "ABC", false);
            Console.WriteLine(results);

            int res = string.Compare("abc", "BAC", false);
            Console.WriteLine(res);

            int resul = string.Compare("BAC", "abc", false);
            Console.WriteLine(resul);

            int resu = string.Compare("bAC", "Abc", false);
            Console.WriteLine(resu);

            Console.WriteLine("Pesho".Equals("pesho"));
            Console.WriteLine("Pwsho" == "Gosho");

            string[] towns = {"Sofia", "Varna", "Plovdiv",
   "Pleven", "Bourgas", "Rousse", "Yambol"};
            string firstTown = towns[0];
            for (int i = 1; i < towns.Length; i++)
            {
                string currentTown = towns[i];
                if (String.Compare(currentTown, firstTown) < 0)
                {
                    firstTown = currentTown;
                }
            }
            Console.WriteLine("First town: {0}", firstTown);


            int[] numbers = { 6, 2, 3, 4, 1, 5 };

            int minNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (minNumber > numbers[i])
                {
                    minNumber = numbers[i];
                }
            }

            Console.WriteLine(minNumber);

            string[] texts = { "6", "2", "3", "4", "1", "5" };

            string minText = texts[0];
            for (int i = 1; i < texts.Length; i++)
            {
                if (string.Compare(minText, texts[i], false) > 0)
                {
                    minText = texts[i];
                }
            }

            Console.WriteLine(minText);
        }
    }
}
