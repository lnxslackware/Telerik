using System;

class BankAccountInfo
{
    static void Main()
    {
        string firstName = "Jonh";
        string middleName = "Johnson";
        string lastName = "Doe";
        decimal balance = 1000000.45M;
        string bankName = "First Investment Bank";
        string iban = "BG01FINV01010101010101";
        string bicCode = "FINVBGSF";
        long firstCardNumber = 1111111111111111;
        long secondCardNumber = 2222222222222222;
        long thirdCardNumber = 3333333333333333;

        Console.WriteLine("Bank Account Details:");
        Console.WriteLine(new string('-',32));
        Console.WriteLine("Full name: {0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Account balance: " + balance + " Euro");
        Console.WriteLine("Bank Name: " + bankName);
        Console.WriteLine("IBAN: " + iban);
        Console.WriteLine("BIC CODE: " + bicCode);
        Console.WriteLine("Credit card 1: " + firstCardNumber);
        Console.WriteLine("Credit card 1: " + secondCardNumber);
        Console.WriteLine("Credit card 1: " + thirdCardNumber);
        Console.WriteLine(new string('-', 32));
    }
}