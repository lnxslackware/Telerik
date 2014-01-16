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