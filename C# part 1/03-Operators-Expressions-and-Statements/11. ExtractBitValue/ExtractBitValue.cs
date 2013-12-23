using System;

class ExtractBitValue
{
    static void Main()
    {
        Console.Write("Please enter the selected integer number: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Please enter the tested bit number: ");
        int b = int.Parse(Console.ReadLine());

        int mask = 1 << b;
        int result = i & mask;
        result = result >> b;
        Console.WriteLine("The bit on position '{0}' of the integer number '{1}' has value '{2}'", b, i, result);
    }
}