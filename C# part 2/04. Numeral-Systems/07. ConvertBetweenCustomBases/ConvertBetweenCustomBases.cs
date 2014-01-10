/*
 * Write a program to convert from any numeral system of given base s to any other 
 * numeral system of base d (2 ≤ s, d ≤  16).
 */

using System;

class ConvertBetweenCustomBases
{
    static string ConvertNumberToCustomBase(string number, int baseS, int baseD)
    {
        string numberInBaseD = string.Empty;
        int numberInDecimal = 0;
        bool isNegativeNumber = false;

        if (baseS == 10)
        {
            numberInDecimal = int.Parse(number);
        }
        else
        {
            for (int i = number.Length - 1, j = 0; i >= 0; i--, j++)
            {
                switch (number[i])
                {
                    case 'A':
                        numberInDecimal += 10 * PowInteger(baseS, j);
                        break;
                    case 'B':
                        numberInDecimal += 11 * PowInteger(baseS, j);
                        break;
                    case 'C':
                        numberInDecimal += 12 * PowInteger(baseS, j);
                        break;
                    case 'D':
                        numberInDecimal += 13 * PowInteger(baseS, j);
                        break;
                    case 'E':
                        numberInDecimal += 14 * PowInteger(baseS, j);
                        break;
                    case 'F':
                        numberInDecimal += 15 * PowInteger(baseS, j);
                        break;
                    case '-':
                        numberInDecimal *= -1;
                        break;
                    default:
                        numberInDecimal += int.Parse(number[i].ToString()) * PowInteger(baseS, j);
                        break;
                }
            }
        }

        if (baseD == 10)
        {
            return numberInDecimal.ToString();
        }

        if (numberInDecimal < 0)
        {
            isNegativeNumber = true;
        }

        while (numberInDecimal != 0)
        {
            int reminder = Math.Abs(numberInDecimal % baseD);

            string stringToAdd = string.Empty;

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

            numberInBaseD += stringToAdd;
            numberInDecimal /= baseD;
        }

        if (isNegativeNumber == true)
        {
            numberInBaseD += "-";
        }

        return ReverseString(numberInBaseD);
    }

    static int PowInteger(int number, int power)
    {
        if (power == 0)
        {
            return 1;
        }

        int poweredInt = number;

        for (int i = 1; i < power; i++)
        {
            poweredInt *= number;
        }

        return poweredInt;
    }

    static string ReverseString(string str)
    {
        char[] tempArray = str.ToCharArray();
        Array.Reverse(tempArray);
        return new string(tempArray);
    }

    static void Main()
    {
        Console.WriteLine("Enter number you want to convert and it's base");
        Console.Write("Number: ");
        string number = Console.ReadLine();
        Console.Write("Base(base >= 2): ");
        int baseS = int.Parse(Console.ReadLine());
        Console.Write("Whitch base do you want to convert to(base <= 16)? ");
        int baseD = int.Parse(Console.ReadLine());

        Console.WriteLine("The number converted to numeral system with base {0} is:", baseD);
        Console.WriteLine(ConvertNumberToCustomBase(number, baseS, baseD));
    }
}