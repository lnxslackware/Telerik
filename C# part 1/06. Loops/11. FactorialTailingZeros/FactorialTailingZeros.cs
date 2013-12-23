using System;
using System.Numerics;

class FactorialTailingZeros
{
    static void Main()
    {
        int inputedNumber = 0;

        Console.Write("Input your selected number: ");

        if (int.TryParse(Console.ReadLine(), out inputedNumber))
        {
            BigInteger factorial = 1;
            int tailingZeros = 0;

            for (int i = inputedNumber; i > 1; i--)
            {
                factorial *= i;
            }

            while (factorial % 10 == 0)
            {
                tailingZeros++;
                factorial = factorial / 10;
            }

            Console.WriteLine("There are {0} tailing zeros in {1}!", tailingZeros, inputedNumber);
        }
        else
        {
            Console.WriteLine("Wrong input value or type");
        }
    }
}