using System;

class ShowTheSign
{
    static void Main()
    {
        Console.Write("Enter first real number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second real number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third real number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        char sign = '-';
        bool oneNumberIsZero = firstNumber == 0 || secondNumber == 0 || thirdNumber == 0;

        if (firstNumber > 0 && ((secondNumber > 0 && thirdNumber > 0) || (secondNumber < 0 && thirdNumber < 0)))
        {
            sign = '+';
        }
        if (firstNumber > 0 && (secondNumber < 0 || thirdNumber < 0))
        {
            sign = '-';
        }
        if (firstNumber < 0 && (secondNumber > 0 || thirdNumber > 0))
        {
            sign = '+';
        }
        if (firstNumber < 0 && ((secondNumber > 0 && thirdNumber > 0) || (secondNumber < 0 && thirdNumber < 0)))
        {
            sign = '-';
        }
        Console.WriteLine(oneNumberIsZero ? "The product of the three numbers is 0" : "The sign of the product of the three numbers is \"{0}\"", sign);
    }
}