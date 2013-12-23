using System;

class CheckIfBitIs1
{
    static void Main()
    {
        Console.Write("Please enter the selected integer number: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Please enter the tested bit number: ");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int result = v & mask;
        bool bit = (result >> p) == 1;

        Console.WriteLine(bit);
    }
}