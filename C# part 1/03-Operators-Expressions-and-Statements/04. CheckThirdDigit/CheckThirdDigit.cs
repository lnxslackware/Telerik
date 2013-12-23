using System;

class CheckThirdDigit
{
    static void Main()
    {
        Console.Write("Please enter an integer: ");
        int integerNumber = int.Parse(Console.ReadLine());
        bool result = (Math.Abs(integerNumber) / 100) % 10 == 7;
        Console.WriteLine(result);

    }
}