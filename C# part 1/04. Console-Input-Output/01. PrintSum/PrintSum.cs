using System;

class PrintSum
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The sum of the three numbers is: {0}", firstNumber + secondNumber + thirdNumber);
    }
}