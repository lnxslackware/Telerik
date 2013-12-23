using System;
using System.Numerics;

class NthCatalanNumber
{
    static void Main()
    {
        int catalanNumber;

        do
        {
            Console.Write("Witch Catalan number do you want to display?: ");
        }
        while (!int.TryParse(Console.ReadLine(), out catalanNumber));

        int doubledN = catalanNumber * 2;
        BigInteger nFactorial = 1;
        BigInteger doubledNFactorial = 1;
        BigInteger nPlusOneFactorial = 1;

        for (int i = catalanNumber; i >= 1; i--)
        {
            nFactorial *= i;
        }

        for (int i = doubledN; i >= 1; i--)
        {
            doubledNFactorial *= i;
        }

        for (int i = catalanNumber + 1; i >= 1; i--)
        {
            nPlusOneFactorial *= i;
        }

        Console.WriteLine("The {0} Catalan number is {1}", catalanNumber, doubledNFactorial / (nPlusOneFactorial * nFactorial));
    }
}