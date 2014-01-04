/*
 * Write a method GetMax() with two parameters that returns the bigger of two integers. 
 * Write a program that reads 3 integers from the console and prints the biggest of them 
 * using the method GetMax().
 */

using System;

class GetMaxMethod
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        int maxNumber = firstNumber;

        if (maxNumber < secondNumber)
        {
            maxNumber = secondNumber;
        }

        return maxNumber;
    }
    static void Main()
    {
        Console.WriteLine("Enter the three numbers");
        Console.Write("First number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        int maxNumber = GetMax(GetMax(firstNumber, secondNumber), thirdNumber);

        Console.WriteLine("The maximal number is: {0}", maxNumber);
    }
}