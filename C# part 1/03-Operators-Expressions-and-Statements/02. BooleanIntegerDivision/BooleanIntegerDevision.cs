using System;

class Program
{
    static void Main()
    {
        Console.Write("Please input a number: ");
        int integerNumber = int.Parse(Console.ReadLine());
        bool result = false;
        if ((integerNumber % 5) == 0 && (integerNumber % 7) == 0)
        {
            result = true;
        }
        Console.WriteLine(result);
    }
}