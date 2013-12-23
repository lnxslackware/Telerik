using System;
using System.Numerics;

class MultiplyAndDivideFactorials
{
    static void Main()
    {
        int kIndex;
        int nIndex;

        Console.WriteLine("Enter \"K\" and \"N\" indexes (1<N<K)");
        do
        {
            Console.Write("Enter \"K\" index: ");
        }
        while (!int.TryParse(Console.ReadLine(), out kIndex));

        do
        {
            Console.Write("Enter \"N\" index: ");
        }
        while (!int.TryParse(Console.ReadLine(), out nIndex));

        if (nIndex > 0 && kIndex > 0)
        {

            if (nIndex > kIndex)
            {
                Console.WriteLine("The N index must be greater than the K index. Switching values...");
                nIndex = nIndex + kIndex;
                kIndex = nIndex - kIndex;
                nIndex = nIndex - kIndex;
            }

            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;
            BigInteger kMinusNFactorial = 1;

            for (int i = nIndex; i > 1; i--)
            {
                nFactorial *= i;
            }

            for (int i = kIndex; i > 1; i--)
            {
                kFactorial *= i;
            }

            for (int i = kIndex - nIndex; i > 1; i--)
            {
                kMinusNFactorial *= i;
            }

            Console.WriteLine("K! = {0}", kFactorial);
            Console.WriteLine("N! = {0}", nFactorial);
            Console.WriteLine("N!*K!/(K-N)! = {0}", (nFactorial * kFactorial) / kMinusNFactorial);
        }
        else
        {
            Console.WriteLine("Both values must be greater than 0!");
        }
    }
}