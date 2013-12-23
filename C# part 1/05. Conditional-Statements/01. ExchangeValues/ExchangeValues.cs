using System;

class ExchangeValues
{
    static void Main()
    {
        Console.Write("Enter first integer: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            secondNumber = firstNumber + secondNumber;
            firstNumber = secondNumber - firstNumber;
            secondNumber = secondNumber - firstNumber;
        }

        Console.WriteLine("Now the first number is {0}", firstNumber);
        Console.WriteLine("Now the second number is {0}", secondNumber);
    }
}