using System;
using System.Numerics;

class CalculateSumOfDividedFactorial
{
    static void Main()
    {
        BigInteger factorial = 1;
        BigInteger sum = 1;

        int nIndex;
        int xIndex;

        do
        {
            Console.Write("Enter \"N\" index: ");
        }
        while (!int.TryParse(Console.ReadLine(), out nIndex));

        do
        {
            Console.Write("Enter \"X\" index: ");
        }
        while (!int.TryParse(Console.ReadLine(), out xIndex));

        for (int i = 1; i <= nIndex; i++)
        {
            for (int j = i; j >= 1; j--)
            {
                factorial *= j;
            }

            sum = sum + (factorial / BigInteger.Pow(xIndex, i));
            factorial = 1;
        }

        Console.WriteLine("The Sum \"1 + 1!/{0} + 2!/{0}^2 + … + {1}!/{0}^{1} = {2}\"", xIndex, nIndex, sum);
    }
}