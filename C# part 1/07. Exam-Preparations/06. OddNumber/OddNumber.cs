using System;

class OddNumber
{
    static void Main()
    {
        int numbersCount = int.Parse(Console.ReadLine());
        long[] numbers = new long[numbersCount];
        long oddNumber = 0;

        for (int i = 0; i < numbersCount; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbersCount; i++)
        {
            if (i == 0)
            {
                oddNumber = 0 ^ numbers[i];
            }
            else
            {
                oddNumber = oddNumber ^ numbers[i];
            }
        }

        Console.WriteLine(oddNumber);
    }
}