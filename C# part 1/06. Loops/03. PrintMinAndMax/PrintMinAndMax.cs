using System;

class PrintMinAndMax
{
    static void Main()
    {
        int count = 0;

        do
        {
            Console.Write("How much numbers do you want to input?: ");
        }
        while (!int.TryParse(Console.ReadLine(), out count));

        int[] sequenceNumbers = new int[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter number: ");
            int inputedNumber = int.Parse(Console.ReadLine());
            sequenceNumbers[i] = inputedNumber;
        }

        int maxNumber = sequenceNumbers[0];
        int minNumber = sequenceNumbers[0];

        for (int i = 0; i < sequenceNumbers.Length; i++)
        {
            if (sequenceNumbers[i] < minNumber)
            {
                minNumber = sequenceNumbers[i];
            }

            if (sequenceNumbers[i] > maxNumber)
            {
                maxNumber = sequenceNumbers[i];
            }
        }
        Console.WriteLine("The minimal number is: {0}", minNumber);
        Console.WriteLine("The maximal number is: {0}", maxNumber);
    }
}