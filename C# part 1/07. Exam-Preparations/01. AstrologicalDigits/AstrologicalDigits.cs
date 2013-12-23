using System;

class AstrologicalDigits
{
    static void Main()
    {
        string numberAsString = Console.ReadLine();
        int numberDigitsSum = 0;
        string numberDigitsSumString = "";
        int digit = 0;

        for (int i = 0; i < numberAsString.Length; i++)
        {
            if (numberAsString[i] == '.' || numberAsString[i] == '-')
            {
                digit = 0;
            }
            else
            {
                digit = Convert.ToInt32(Char.GetNumericValue(numberAsString[i]));
            }
            numberDigitsSum += digit;
        }

        while (numberDigitsSum > 9)
        {
            numberDigitsSumString = numberDigitsSum.ToString();
            numberDigitsSum = 0;

            for (int i = 0; i < numberDigitsSumString.Length; i++)
            {
                numberDigitsSum += Convert.ToInt32(Char.GetNumericValue(numberDigitsSumString[i]));
            }
        }
        Console.WriteLine(numberDigitsSum);
    }
}