using System;

    class ThirdDigit
    {
        static void Main()
        {
            int number = 1732;
            bool thirdDigitIs5 = (number / 100) % 10 == 7;
            Console.WriteLine(thirdDigitIs5);
        }
    }

