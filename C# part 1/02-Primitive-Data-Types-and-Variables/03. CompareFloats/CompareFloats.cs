using System;

class CompareFloats
{
    static void Main()
    {
        Console.Write("Please input the first floating-point number: ");
        decimal firstNumber = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Please input the second floating-point number: ");
        decimal secondNumber = Convert.ToDecimal(Console.ReadLine());

        decimal allowedDifference = 0.000001M;

        Console.WriteLine("Allowed difference between numbers: (-){0}", allowedDifference);
        Console.WriteLine("Current difference between numbers: {0}", (firstNumber - secondNumber));
        Console.Write("Result: ");

        if (Math.Abs(firstNumber - secondNumber) <= allowedDifference)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}