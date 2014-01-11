/*
 * Write a program to convert hexadecimal numbers to their decimal representation.
 */

using System;

class ConvertHexToDec
{
    static int HexToDec(string hexNumber)
    {
        hexNumber = hexNumber.ToUpper();
        int decimalNumber = 0;

        for (int i = hexNumber.Length - 1, j = 0; i >= 0; i--, j++)
        {
            switch (hexNumber[i])
            {
                case 'A':
                    decimalNumber += 10 * (int)Math.Pow(16, j);
                    break;
                case 'B':
                    decimalNumber += 11 * (int)Math.Pow(16, j);
                    break;
                case 'C':
                    decimalNumber += 12 * (int)Math.Pow(16, j);
                    break;
                case 'D':
                    decimalNumber += 13 * (int)Math.Pow(16, j);
                    break;
                case 'E':
                    decimalNumber += 14 * (int)Math.Pow(16, j);
                    break;
                case 'F':
                    decimalNumber += 15 * (int)Math.Pow(16, j);
                    break;
                case '-':
                    decimalNumber *= -1;
                    break;
                default:
                    decimalNumber += int.Parse(hexNumber[i].ToString()) * (int)Math.Pow(16, j);
                    break;
            }
        }

        return decimalNumber;
    }

    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string hexNumber = Console.ReadLine();

        Console.WriteLine("The number in decimal is:");
        Console.WriteLine(HexToDec(hexNumber));
    }
}