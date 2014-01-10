/*
 * Write a program to convert binary numbers to hexadecimal numbers (directly).
 */

using System;

class BinToHexDirect
{
    static string BinToHex(string binNumber)
    {
        string hexNumber = string.Empty;

        int padding = 4 - (binNumber.Length % 4);

        if (padding != 0)
        {
            binNumber = binNumber.PadLeft(padding + binNumber.Length, '0');
        }

        for (int i = 0; i < binNumber.Length; i += 4)
        {
            string testedString = string.Empty;
            
            for (int j = i; j < i + 4; j++)
            {
                testedString += binNumber[j];
            }

            switch (testedString)
            {
                case "0000":
                    hexNumber += "0";
                    break;
                case "0001":
                    hexNumber += "1";
                    break;
                case "0010":
                    hexNumber += "2";
                    break;
                case "0011":
                    hexNumber += "3";
                    break;
                case "0100":
                    hexNumber += "4";
                    break;
                case "0101":
                    hexNumber += "5";
                    break;
                case "0110":
                    hexNumber += "6";
                    break;
                case "0111":
                    hexNumber += "7";
                    break;
                case "1000":
                    hexNumber += "8";
                    break;
                case "1001":
                    hexNumber += "9";
                    break;
                case "1010":
                    hexNumber += "A";
                    break;
                case "1011":
                    hexNumber += "B";
                    break;
                case "1100":
                    hexNumber += "C";
                    break;
                case "1101":
                    hexNumber += "D";
                    break;
                case "1110":
                    hexNumber += "E";
                    break;
                case "1111":
                    hexNumber += "F";
                    break;
                default:
                    break;
            }
        }

        return hexNumber;
    }

    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binaryNumber = Console.ReadLine();

        Console.WriteLine("The number in hexadecimal is:");
        Console.WriteLine(BinToHex(binaryNumber).TrimStart('0'));
    }
}