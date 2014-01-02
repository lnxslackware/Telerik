/*
 * Write a method that returns the last digit of given integer as an English word. 
 * Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".
 */

using System;

class ReturnLastDigitInEnglish
{
    static string ReturnLastDigitAsString(string numberAsString)
    {
        string lastDigit = numberAsString[numberAsString.Length -1].ToString();

        switch (lastDigit)
        {
            case "0":
                lastDigit = "zero";
                break;
            case "1":
                lastDigit = "one";
                break;
            case "2":
                lastDigit = "two";
                break;
            case "3":
                lastDigit = "three";
                break;
            case "4":
                lastDigit = "four";
                break;
            case "5":
                lastDigit = "five";
                break;
            case "6":
                lastDigit = "six";
                break;
            case "7":
                lastDigit = "seven";
                break;
            case "8":
                lastDigit = "eight";
                break;
            case "9":
                lastDigit = "nine";
                break;
            default:
                lastDigit = "Wrong input";
                break;
        }

        return lastDigit;
    }
    static void Main()
    {
        Console.Write("Input number: ");
        string userInput = Console.ReadLine();
        string output = ReturnLastDigitAsString(userInput);

        Console.WriteLine("number: {0} -> {1}", userInput, output);
    }
}