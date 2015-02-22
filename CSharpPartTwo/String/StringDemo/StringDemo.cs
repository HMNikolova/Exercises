using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class StringDemo
    {
        static void Main(string[] args)
        {
            //toString

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            //Console.WriteLine(numbers.ToString());//не изкарва коректен отговор

            string numberAsString = string.Join(", ", numbers);
            Console.WriteLine(numberAsString);

            //string text = string.Empty; //празен текст

            //string text = "Pesho";
            ////Console.WriteLine(text[3]);// показва 3-тия индекс
            //for (int i = 0; i < text.Length; i++)
            //{
            //    Console.WriteLine("text[{0}] - {1}", i + 1, text[i]);//i + 1 - така индекса започва от 1, по нагледно за потребителя 
            //}
        }
    }
}
