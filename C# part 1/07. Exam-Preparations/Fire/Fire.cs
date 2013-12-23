using System;

class Fire
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = n / 2; i > 0; i--)
        {
            for (int j = 1; j <= n / 2; j++)
            {
                if (j == i)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }

            for (int j = n / 2; j >= 1; j--)
            {
                if (j == i)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

        for (int i = (n / 2) / 2; i > 0; i--)
        {
            for (int j = (n / 2) / 2; j >= 1; j--)
            {
                if (j == i)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }

            for (int j = 1; j <= n / 2; j++)
            {
                Console.Write(".");
            }

            for (int j = 1; j <= (n / 2) / 2; j++)
            {
                if (j == i)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine(new string('-', n));

        for (int i = 0; i < n / 2; i++)
        {
            for (int j = n / 2; j >= 0; j--)
            {
                if (i == j)
                {
                    Console.Write(new string('.', i));
                    Console.Write(new string('\\', n / 2 - i));
                }
            }

            for (int j = 0; j <= n / 2; j++)
            {
                if (i == j)
                {
                    Console.Write(new string('/', n / 2 - i));
                    Console.Write(new string('.', i));
                }
            }
            Console.WriteLine();
        }
    }
}