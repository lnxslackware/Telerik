/*
 * Write a program to convert binary numbers to their decimal representation.
 */

using System;

class ConvertBinToDec
{
    static int BinToDec(string binaryNumber)
    {
        int resultDecNumber = 0;

        for (int i = binaryNumber.Length - 1, j = 0; i >= 0; i--, j++)
        {
            if (binaryNumber[i] == '1')
            {
                resultDecNumber += int.Parse(binaryNumber[i].ToString()) * (int)Math.Pow(2, j);
            }
        }

        return resultDecNumber;
    }

    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binaryNumber = Console.ReadLine();

        Console.WriteLine("The number in decimal is:");
        Console.WriteLine(BinToDec(binaryNumber));
    }
}