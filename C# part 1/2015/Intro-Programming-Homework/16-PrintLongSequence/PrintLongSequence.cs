/*
 * Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
 * You might need to learn how to use loops in C# (search in Internet).
 */

namespace _16_PrintLongSequence
{
    using System;
    using System.Text;

    class PrintLongSequence
    {
        static void Main()
        {
            int firstMember = 2;
            int tottalCount = 1000;
            int lastMember = firstMember + tottalCount - 1;
            StringBuilder output = new StringBuilder();
            for (int i = firstMember; i <= lastMember; i++)
            {
                if (i % 2 != 0)
                {
                    output.Append("-");
                }

                output.Append(i);

                if (i != lastMember)
                {
                    output.Append(", ");
                }
            }

            Console.WriteLine(output);
        }
    }
}