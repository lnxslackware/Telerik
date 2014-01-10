/*
 * Write a program to convert decimal numbers to their binary representation.
 */

using System;

class ConvertDecToBin
{
    static string DecToBin(int number)
    {
        bool isNegativeNumber = false;
        string numberToBinAsString = string.Empty;

        if (number < 0)
        {
            isNegativeNumber = true;
            number++;
        }

        int counter = 0;

        while (number != 0)
        {
            int reminder = Math.Abs(number % 2);
            if (reminder == 1)
            {
                if (isNegativeNumber == true)
                {
                    numberToBinAsString += '0';
                }
                else
                {
                    numberToBinAsString += '1';
                }
            }
            else
            {
                if (isNegativeNumber == true)
                {
                    numberToBinAsString += '1';
                }
                else
                {
                    numberToBinAsString += '0';
                }
            }

            counter++;
            number = number / 2;
        }

        numberToBinAsString = ReverseString(numberToBinAsString);

        if (isNegativeNumber == true)
        {
            numberToBinAsString = numberToBinAsString.PadLeft((32 - numberToBinAsString.Length) + numberToBinAsString.Length, '1');
        }
        else
        {
            numberToBinAsString = numberToBinAsString.PadLeft((32 - numberToBinAsString.Length) + numberToBinAsString.Length, '0');
        }

        return numberToBinAsString;
    }

    static string ReverseString(string str)
    {
        char[] tempArray = str.ToCharArray();
        Array.Reverse(tempArray);
        return new string(tempArray);
    }

    static void Main()
    {
        Console.Write("Enter decimal number to convert: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The number in binary is:");
        Console.WriteLine(DecToBin(decimalNumber));
    }
}