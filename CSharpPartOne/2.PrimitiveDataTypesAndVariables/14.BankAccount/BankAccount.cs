/*14. A bank account has a holder name (first name, middle name and last name), 
available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers 
associated with the account. Declare the variables needed to keep the information for a 
single bank account using the appropriate data types and descriptive names.*/

using System;

    class BankAccount
    {
        static void Main(string[] args)
        {
            string firstName = "Hristina";
            string middleName = "Marinova";
            string lastName = "Nikolova";
            decimal balance = 1000;
            string bankName = "DSK";
            string IBAN = "";
            string BIC = "";
            ulong creditCard1 = 3333;
            ulong creditCard2 = 555555;
            ulong creditCard3 = 656565;
        }
    }

