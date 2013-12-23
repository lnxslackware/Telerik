using System;

class FindTheBiggestNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        int biggestNumber = firstNumber;

        if (firstNumber < secondNumber)
        {
            biggestNumber = secondNumber;
        }
        if (biggestNumber < thirdNumber)
        {
            biggestNumber = thirdNumber;
        }

        Console.WriteLine("The biggest of the three numbers is {0}", biggestNumber);
    }
}