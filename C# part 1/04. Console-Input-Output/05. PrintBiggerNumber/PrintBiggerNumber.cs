using System;

class PrintBiggerNumber
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The greater number is {0}", (firstNumber > secondNumber) ? firstNumber : secondNumber);
    }
}