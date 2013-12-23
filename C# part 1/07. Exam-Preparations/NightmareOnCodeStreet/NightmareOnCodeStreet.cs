using System;

class NightmareOnCodeStreet
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        int numbersCountInOddPositions = 0;
        int sumOfDigitsInOddPositions = 0;
        int currentDigit;

        for (int i = 0; i < inputString.Length; i++)
        {
            if ((i % 2 != 0) && (int.TryParse(inputString[i].ToString(), out currentDigit)))
            {
                //int currentDigit = int.Parse(inputString[i].ToString());
                sumOfDigitsInOddPositions += currentDigit;
                numbersCountInOddPositions++;
            }
        }
        Console.WriteLine("{0} {1}", numbersCountInOddPositions, sumOfDigitsInOddPositions);
    }
}