using System;
using System.Numerics;

class FactorialDivision
{
    static void Main()
    {
        int nIndex;
        int kIndex;

        Console.WriteLine("Enter \"N\" and \"K\" indexes (1<K<N)");
        do
        {
            Console.Write("Enter \"N\" index: ");
        }
        while (!int.TryParse(Console.ReadLine(), out nIndex));

        do
        {
            Console.Write("Enter \"K\" index: ");
        }
        while (!int.TryParse(Console.ReadLine(), out kIndex));
        if (nIndex > 0 && kIndex > 0)
        {
            if (nIndex < kIndex)
            {
                Console.WriteLine("The N index must be greater than the K index. Switching values...");
                nIndex = nIndex + kIndex;
                kIndex = nIndex - kIndex;
                nIndex = nIndex - kIndex;
            }

            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;

            for (int i = nIndex; i >= 1; i--)
            {
                nFactorial *= i;
            }

            for (int i = kIndex; i >= 1; i--)
            {
                kFactorial *= i;
            }

            Console.WriteLine("N! = {0}", nFactorial);
            Console.WriteLine("K! = {0}", kFactorial);
            Console.WriteLine("N!/K! = {0}", nFactorial / kFactorial);
        }
        else
        {
            Console.WriteLine("Both values must be greater than 0!");
        }
    }
}