using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Pesho";
            //string newStr = text.Replace('e', '!');//навсякъде където видиш "е" направими я на "!"
            //Console.WriteLine(newStr);

            //replace-ване на стрингове
            //string text = "Pesho";
            //string newStr = text.Replace("Pe", "Go");//навсякъде където видиш "Pe" направими го на "Go"
            //Console.WriteLine(newStr);

            //наслагване на replace-ове
            //string text = "Pesho";
            //string newStr = text.Replace("Pe", "Go").Replace("sho", "ivan").Replace("ivan", "mariq");
            //Console.WriteLine(newStr);

            string text = "Pesho";
            //долния ред може да се присвои по показания начин
            text = text.Replace("Pe", "Go").Replace("sho", "ivan").Replace("ivan", "mariq").Substring(2);
            //може да наслагваме и други неща, като substring например и да изкара само mariq
            Console.WriteLine(text);
        }
    }
}
