using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concat
{
    class Program
    {
        static void Main(string[] args)
        {
            //string result = string.Concat("pesho", " gosho");
            //Console.WriteLine(result);
            ////същото като Concat е и 
            //string results = "a" + "b";
            //Console.WriteLine(results);

            //int a = 11;
            //string text = "a";

            //Console.WriteLine(a + text);

            string firstName = "Telerik";
            string lastName = "Academy";

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            // Telerik Academy

            int age = 5;

            string nameAndAge =
                "Name: " + fullName +
                "\nAge: " + age;
            Console.WriteLine(nameAndAge);

        }
    }
}
