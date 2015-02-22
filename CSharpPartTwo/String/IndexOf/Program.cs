using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "pesho";
            //int index = text.IndexOf("pes");
            //Console.WriteLine(index + "pes".Length - 1);//на кой индекс завършва pes

            //string text = "gosho pesho";
            //int index = text.IndexOf("pes");
            ////int index = text.IndexOf("pes", 6);//може и да зададем от кой индекс да започне търсенето
            //Console.WriteLine(index);//казва от 6-тия индекс започва pes

            //string text = "gosho pesho gosho pesho ivan pesho gosho";
            ////търсим Pesho
            //int index = 0;
            //while (true)
            //{
            //    int found = text.IndexOf("pesho", index);
            //    if (found < 0)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(found);
            //    index = found + 1;
            //}

            string text = "gosho pesho gosho pesho ivan pesho gosho";

            int found = text.LastIndexOf("pesho");
            Console.WriteLine(found);



            string str = "C# Programming Course";
            int index = str.IndexOf("C#"); // index = 0
            index = str.IndexOf("Course"); // index = 15
            index = str.IndexOf("COURSE"); // index = -1
            // IndexOf is case-sensetive. -1 means not found
            index = str.IndexOf("ram"); // index = 7
            index = str.IndexOf("r"); // index = 4
            index = str.IndexOf("r", 5); // index = 7
            index = str.IndexOf("r", 8); // index = 18
        }
    }
}
