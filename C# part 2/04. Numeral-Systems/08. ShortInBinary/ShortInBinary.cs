/*
 * Write a program that shows the binary representation of given 16-bit signed 
 * integer number (the C# type short).
 */

using System;

class ShortInBinary
{
    static string ShortToBin(short number)
    {
        string numberInBin = string.Empty;
        bool isNegativeNumber = number < 0;

        if (isNegativeNumber == true)
        {
            number++;
        }

        while (number != 0)
        {
            int reminder = Math.Abs(number % 2);

            if (reminder == 1)
            {
                if (isNegativeNumber == true)
                {
                    numberInBin += "0";
                }
                else
                {
                    numberInBin += "1";
                }
            }
            else
            {
                if (isNegativeNumber == true)
                {
                    numberInBin += "1";
                }
                else
                {
                    numberInBin += "0";
                }
            }

            number /= 2;
        }

        numberInBin = ReverseString(numberInBin);

        int difference = 16 - numberInBin.Length;

        if (isNegativeNumber == true)
        {
            numberInBin = numberInBin.PadLeft(difference + numberInBin.Length, '1');
        }
        else
        {
            numberInBin = numberInBin.PadLeft(difference + numberInBin.Length, '0');
        }

        return numberInBin;
    }

    static string ReverseString(string str)
    {
        char[] tempArray = str.ToCharArray();
        Array.Reverse(tempArray);
        return new string(tempArray);
    }

    static void Main()
    {
        Console.Write("Enter number between -32768 and 32767: ");
        short number = short.Parse(Console.ReadLine());

        Console.WriteLine("The number in binary is:");
        Console.WriteLine(ShortToBin(number));
    }
}