using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        int numbersCount = 5;
        int[] numbers = new int[numbersCount];
        int multipleCounter = 0;
        int testNumber = 0;

        for (int i = 0; i < numbersCount; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        while (multipleCounter < 3)
        {
            testNumber++;

            for (int i = 0; i < numbersCount; i++)
            {
                if (testNumber % numbers[i] == 0 && testNumber / numbers[i] != 0)
                {
                    multipleCounter++;
                }
            }
            if (multipleCounter < 3)
            {
                multipleCounter = 0;
            }
        }
        Console.WriteLine(testNumber);
    }
}