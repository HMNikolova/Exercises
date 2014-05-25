/*7: Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime. */

using System;

class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter positive integer number here to check if is prime:");

        Console.WriteLine(new string('-', 63));

        int inputNumber = int.Parse(Console.ReadLine());
        if (inputNumber < 2) // if entered number is negative...
        {
            Console.WriteLine("The number is not prime!!!"); // ...print error and return
            return;
        }

        int devider = 2;
        int maxDevider = (int)Math.Sqrt(inputNumber);
        bool prime = true; // at first the "inputNumber" is prime

        while (prime && (devider <= maxDevider)) // while "inputNumber" is prime (1) and devider <= maxDevider (1) -> go to if loop
        {
            if (inputNumber % devider == 0) //if input number devide by devider without remainder...
            {
                prime = false; //...the input number is not prime
                Console.WriteLine("The number is not prime because: {0}*{1}={2}",
                    devider, inputNumber / devider, inputNumber); //proof that input number is not prime
            }
            devider++;
        }
        Console.WriteLine("The number {0} is prime? -> {1}", inputNumber, prime);
        Console.WriteLine(); //empty row
    }
}