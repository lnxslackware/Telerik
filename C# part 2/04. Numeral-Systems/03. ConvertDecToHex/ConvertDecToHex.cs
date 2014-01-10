/*
 * Write a program to convert decimal numbers to their hexadecimal representation.
 */

using System;

class ConvertDecToHex
{
    static string DecToHex(int number)
    {
        bool isNegative = number < 0;
        string hexNumber = string.Empty;
        string stringToAdd = string.Empty;

        if (isNegative == true)
        {
            number++;
        }

        while (number != 0)
        {
            int reminder = Math.Abs(number % 16);

            if (isNegative == true)
            {
                reminder = 15 - reminder;
            }

            switch (reminder)
            {
                case 10:
                    stringToAdd = "A";
                    break;
                case 11:
                    stringToAdd = "B";
                    break;
                case 12:
                    stringToAdd = "C";
                    break;
                case 13:
                    stringToAdd = "D";
                    break;
                case 14:
                    stringToAdd = "E";
                    break;
                case 15:
                    stringToAdd = "F";
                    break;
                default:
                    stringToAdd = reminder.ToString();
                    break;
            }

            hexNumber += stringToAdd;
            number /= 16;
        }

        return ReverseString(hexNumber).PadLeft((8 - hexNumber.Length) + hexNumber.Length, 'F');
    }

    static string ReverseString(string str)
    {
        char[] tempArray = str.ToCharArray();
        Array.Reverse(tempArray);
        return new string(tempArray);
    }

    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The number in hexadecimal is:");
        Console.WriteLine(DecToHex(decimalNumber));
    }
}