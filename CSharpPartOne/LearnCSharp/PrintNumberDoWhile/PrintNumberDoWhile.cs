using System;

    class PrintNumberDoWhile
    {
        static void Main()
        {
            string str;
            int num;
            do
            {
              Console.Write("Enter a number: ");
              str = Console.ReadLine();  
            } while (!int.TryParse(str, out num));

            Console.WriteLine("Voala!");
        }
    }
