using System;

class CheckThirdBit
{
    static void Main()
    {
        Console.Write("Input an integer: ");
        int integerNumber = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int result = integerNumber & mask;
        bool bit = (result >> 3) > 0;
        Console.WriteLine(bit);
    }
}