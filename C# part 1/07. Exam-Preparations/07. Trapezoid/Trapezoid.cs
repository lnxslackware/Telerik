using System;

class Trapezoid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int catet = n;

        Console.WriteLine(new string('.', n) + new string('*', n));
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j <= n * 2; j++)
            {
                if (j == n * 2 || j == catet)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            catet--;
            Console.WriteLine();
        }
        Console.WriteLine(new string('*', n * 2));
    }
}