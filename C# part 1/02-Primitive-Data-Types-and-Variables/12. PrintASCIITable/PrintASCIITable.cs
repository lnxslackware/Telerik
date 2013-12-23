using System;

class PrintASCIITable
{
    static void Main()
    {
        Console.WriteLine("ASCII Table");
        for (int i = 0; i <= 127; i++)
        {
            Console.WriteLine("{0, -4} | {1}", i, (char)i);
        }
    }
}