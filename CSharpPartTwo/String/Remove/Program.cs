using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove
{
    class Program
    {
        static void Main(string[] args)
        {
            //Remove(index, length) - махни ми от даден индекс на каква дължина да ви бъде изтрито
            //работи като substring, връща ни резултата след изтритата част
            string text = "Pesho";
            text = text.Remove(1, 2);//махни ми от 1 индекс следващите 2 символа
            //text = text.Remove(1);//маха всичко след 1 индекс
            Console.WriteLine(text);
        }
    }
}
