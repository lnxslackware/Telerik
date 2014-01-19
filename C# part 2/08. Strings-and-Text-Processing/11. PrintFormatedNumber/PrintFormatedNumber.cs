using System;

class PrintFormatedNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("As decimal:");
        Console.WriteLine("{0,15:D}", number);

        Console.WriteLine("As hexadecimal:");
        Console.WriteLine("{0,15:X}", number);

        Console.WriteLine("As percentage:");
        Console.WriteLine("{0,15:P}", number);

        Console.WriteLine("As scientific notation:");
        Console.WriteLine("{0,15:G}", number);
    }
}