using System;

class HowOldAreYou
{
    static void Main()
    {

        int yearBorn;
        while (true)
        {
            Console.WriteLine("Please enter the year you were born:");
            if (int.TryParse(Console.ReadLine(), out yearBorn) && yearBorn > 1900 && yearBorn < DateTime.Now.Year)
            {
                break;
            }
            else
            {
                Console.WriteLine("Incorect data, please try again!");
            }
        }

        int yearsNow = DateTime.Now.Year - yearBorn;
        int futureAge = yearsNow + 10;
        Console.WriteLine("Your age now is {0} and you will be {1} years old after 10 years", yearsNow, futureAge);

        //another solution

        Console.WriteLine("Enter your age: ");
        string ages = Console.ReadLine();
        int age = int.Parse(ages);

        Console.WriteLine("After 10 years, you are " + (age + 10) + " years old");

    }
}
