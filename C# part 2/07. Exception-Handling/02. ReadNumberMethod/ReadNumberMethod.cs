/*
 * Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
 * If an invalid number or non-number text is entered, the method should throw an exception. 
 * Using this method write a program that enters 10 numbers:
 *          a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

using System;

class ReadNumberMethod
{
    static int ReadNumber(int start, int end)
    {
        string inputString = Console.ReadLine();
        int number;
        bool isNumber = int.TryParse(inputString, out number);
        
        if (isNumber == false)
        {
            throw new FormatException();
        }

        if (number < start || number > end)
        {
            throw new ArgumentOutOfRangeException();
        }

        return number;
    }

    static void Main()
    {
        int start = 2;
        int end = 99;

        for (int i = 0; i < 10; i++)
        {
            start = ReadNumber(start, end);
        }
    }
}