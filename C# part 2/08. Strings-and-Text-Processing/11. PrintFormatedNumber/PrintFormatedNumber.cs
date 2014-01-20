/*
 * Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.
 */

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