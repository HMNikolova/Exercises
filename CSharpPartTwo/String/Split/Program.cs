using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "1    2 3 4 5 6";//направи ми масив от стрингове разцепен по някакъв критерии
            //string[] numbersAsText = text.Split(new char[] {' ', ',', '!'}, StringSplitOptions.RemoveEmptyEntries);//искам да сплитваш по интервал и да махаш празните интервали
            ////string[] numbersAsText = text.Split(',', ' ');
            //int[] numbers = new int[numbersAsText.Length];
            //for (int i = 0; i < numbersAsText.Length; i++)
            //{
            //    numbers[i] = int.Parse(numbersAsText[i]);
            //}

            //string text = "1pesho2pesho3pesho4pesho5pesho6";
            //string[] numbersAsText = text.Split(new string[] { "pesho" }, StringSplitOptions.RemoveEmptyEntries);
            //int[] numbers = new int[numbersAsText.Length];
            //for (int i = 0; i < numbersAsText.Length; i++)
            //{
            //    numbers[i] = int.Parse(numbersAsText[i]);
            //}


            //1 2 3 4 5 6
            //прехвърляне на входa без for цикли
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //сплитни ми ги, масива, който съм получил е стрингове
            //Select - за всеки стринг,който съм получил parse-ними го
            //ToArray - и това, което получиш ми го направи на масив



            string listOfBeers = "Amstel, Zagorka, Tuborg, Becks.";
            string[] beers = listOfBeers.Split(' ', ',', '.');
            //string[] beers = listOfBeers.Split(
            //    new char[] {' ', ',', '.'}, 
            //    StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Available beers are:");
            foreach (string beer in beers)
            {
                // Two sequential separators in the input cause
                // presence of empty element in the result
                if (beer != "")
                {
                    Console.WriteLine(beer);
                }
            }
        }
    }
}
