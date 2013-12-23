using System;

class KaspichaniaBoats
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < 2; i++)
        //{
        //    for (int j = 1; j <= (n * 2) + 1; j++)
        //    {
        //        Console.Write(".");
        //        if (i == 0 && j == (n + 1))
        //        {
        //            Console.Write("*");
        //        }
        //        if (i == 1 && j == n)
        //        {
        //            Console.Write(new string('*', 3));
        //            j += 2;
        //        }
        //    }
        //    Console.WriteLine();
        //}


        Console.WriteLine(new string('.', n) + "*" + new string('.', n));
        for (int i = 1; i < n; i++)
        {
            for (int j = n; j >= 1; j--)
            {
                if (i == j)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.Write("*");
            //for (int j = 0; j < 1; j++)
            //{
            //    Console.Write("*");
            //}

            for (int j = 1; j <= n; j++)
            {
                if (i == j)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine(new string('*', (n * 2) + 1));

        for (int i = 0; i < (n / 2) + 1; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}