// 6.Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.


using System;

    class BooleanVariable
    {
        static void Main()
        {
            bool isFemale;
            Console.Write("What is your gender (male/female): ");
            string myGendeer = Console.ReadLine();

            if (myGendeer == "female")
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;            
            }

            Console.WriteLine("Are you female: "+ isFemale);
        }
    }
}
