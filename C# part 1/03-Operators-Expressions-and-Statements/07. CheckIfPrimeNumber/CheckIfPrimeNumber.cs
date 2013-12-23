using System;

class Program
{
    static void Main()
    {
        Console.Write("Please input an integer between 1 and 100: ");
        int checkedNumber = int.Parse(Console.ReadLine());
        bool result = true;
        for (int i = 2; i <= Math.Sqrt(checkedNumber); i++)
        {
            result = result && ((checkedNumber % i) != 0);
        }
        Console.WriteLine(result ? "The integer {0} is a prime number!" : "The integer {0} is not a prime number!", checkedNumber);
    }
}