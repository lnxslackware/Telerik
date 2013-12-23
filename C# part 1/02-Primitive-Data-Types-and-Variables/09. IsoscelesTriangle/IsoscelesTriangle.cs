using System;

class IsoscelesTriangle
{
    static void Main()
    {
        char symbol = '\u00A9';
        int rows = 3;
        int spacesMaxCount = 2;
        int symbolsStartCount = 1;

        for (int loops = 0; loops < rows; loops++)
        {
            Console.Write(new string(' ', spacesMaxCount));
            Console.Write(new string(symbol, symbolsStartCount));
            Console.WriteLine();

            spacesMaxCount--;
            symbolsStartCount = symbolsStartCount + 2;
        }
    }
}