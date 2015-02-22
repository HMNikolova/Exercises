using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder result = new StringBuilder();//празен
            //result.Append("b");//залепи
            //result.Append("a");
            //result.Append("c");
            //for (int i = 0; i < 100000000; i++)
            //{
            //    result.Append("a");
            //}
            //string text = result.ToString();
            //Console.WriteLine(text);

            //for (int i = 0; i < 100; i++)
            //{
            //    result.AppendLine("abvbvbc");//залепва линия
            //}
            //string text = result.ToString().Trim();//Trim на последния ред ще ни махне празния ред
            //Console.WriteLine(text);

            //StringBuilder result = new StringBuilder(1000000);//ако знаем, че ще са много символите по-добре е да сложим размер на : StringBuilder result = new StringBuilder(1000000);
            //for (int i = 0; i < 100; i++)
            //{
            //    result.AppendLine("abvbvbc");
            //}
            //Console.WriteLine(result.Capacity);//колко е голям масива
            //Console.WriteLine(result.Length);//това, което сме напълнили
            //Console.WriteLine(result[100]);//какво има на 100-ния символ
            //Console.WriteLine(result.Insert(2, "%"));//на кой индекс да вмъкне нещо
            //string text = result.ToString().Trim();
            //Console.WriteLine(text);


            StringBuilder result = new StringBuilder();
            result.Append("abcde");
            result.Insert(2, "%");//на кой индекс да вмъкне нещо
            result[3] = 'a';//сменя "с" с "а" 
            Console.WriteLine(result.ToString());
        }
    }
}
