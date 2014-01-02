/*
 * Write a method that reverses the digits of given decimal number. Example: 256 -> 652
 */

using System;

class ReverseDigits
{
    static string ReverseString(string str)
    {
        string reversedString = "";
        for (int i = 0; i < str.Length; i++)
        {
            reversedString += str[str.Length - 1 - i];
        }
        return reversedString;
    }

    static void Main()
    {
        //Input
        Console.Write("Enter a decimal digit: ");
        string userNumberAsString = Console.ReadLine();

        //Calling the method
        string reversedNumber = ReverseString(userNumberAsString);

        //Output
        Console.WriteLine("The reversed number is: {0}", reversedNumber);
    }
}