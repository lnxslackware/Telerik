using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Please input an integer: ");
        int testedNumber = int.Parse(Console.ReadLine());
        bool result = (testedNumber % 2) == 0;
        Console.WriteLine(result ? "The given integer is even." : "The given integer is odd.");
    }
}