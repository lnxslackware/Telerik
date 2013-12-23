using System;

class ModifyBit
{
    static void Main()
    {
        Console.Write("Please enter the selected integer number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the tested bit number: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Please enter the selected value (0 or 1): ");
        int v = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        n = n ^ mask;
        Console.WriteLine(n);
    }
}