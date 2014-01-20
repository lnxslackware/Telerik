/*
 * Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.
 */

using System;

class Read20_CharString
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();

        if (str.Length < 20)
        {
            str = str.PadRight(20, '*');
        }

        if (str.Length > 20)
        {
            str = str.Substring(0, 20);
        }

        Console.WriteLine(str);
    }
}