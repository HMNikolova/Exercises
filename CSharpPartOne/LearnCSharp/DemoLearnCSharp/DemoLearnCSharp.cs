using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLearnCSharp
{
    class DemoLearnCSharp
    {
        static void Main(string[] args)
        {
            //double colaPrice = 1.20;
            //string cola = "Coca Cola";
            //Console.WriteLine("{0,-15} | {1,10:F2} |", cola, colaPrice);//{0,-15} - показва колко символа да запази 0(cola)
            //Console.WriteLine();

            //Console.WriteLine("{0,-10}", "the");//така работи със string, с минус започва в началото на реда
            //Console.WriteLine();

            //Console.WriteLine("{0,10}", "the");//string, с плюс отмества реда с толкова символи с колкото сме му дали
            //Console.WriteLine();



            //double a = 15.5;
            //int b = 14;
            //Console.Write("{0} + {1} = {2}\n\n", a, b, a + b);// 15.5 + 14 = 29.5


            ////

            //Console.WriteLine("{0:C}", 10);//показва валута - https://msdn.microsoft.com/en-us/library/dwhawy9k(v=vs.110).aspx
            //Console.WriteLine("{0:F3}", 10);//F3 може да се запише и 0.000 - показва колко нули да имам числото след десетичната запетая
            //Console.WriteLine("{0:X}", 198);//показва резулата в шестнадесетична бройна система

            //Console.Read();//принтира клавиш, връща резултати от тип int

            ////to.String - ако не е дефиниран изкарва типа на данните
            //ConsoleKeyInfo key = Console.ReadKey();
            //Console.WriteLine();
            //Console.WriteLine("Key name: " + key.Key);//например натискаме S и то казва: клавиша е S. Това е еквивалентно на: Console.WriteLine("Key name: " + key.Key.ToString());
            //Console.WriteLine("Key number: " + (int)key.Key);//кастване към int - казва S е номер 83 от аски таблицата
            //Console.WriteLine("Special keys: [{0}] ", key.Modifiers);//специален клавиш, ако не е въведен изписва [0]
            //Console.WriteLine("Character entered: " + key.KeyChar);//коя е буквата на този клавиш


            //Console.WriteLine(num);

            //Console.ReadLine();//връща String
            //paste в конзолата - отиваме на properties->quick edit mode->ok и десен бутон в конзолата на това, което искаме да пейстнеме


            //string str = Console.ReadLine();
            //int number = int.Parse(str);//parse може да приема int, long, float
            //int num = int.Parse(Console.ReadLine());//този ред е еквивалентен на горните два, но при дебъгване не се знае какво ще се въвежда
            //Console.WriteLine("You entered: {0}", number);

            //char symbol = '\u0019';
            //Console.WriteLine((int)symbol);//експлицитно кастване


            //int num = Convert.ToInt32("00000101", 2);//конвертира двойчното число в десетично. 2 може да бъде 8 или 16 в зависимост каква бройна система използваме
            //Console.WriteLine(num);
            //Console.WriteLine("{0:x}", 198);//както и обратното от десетична в шестнадесетична бройна система
            //Convert.ToInt32(string) – string --> int
            //Convert.ToSingle(string)– string --> float
            //Convert.ToInt64(string)– string --> long







        }
    }
}
