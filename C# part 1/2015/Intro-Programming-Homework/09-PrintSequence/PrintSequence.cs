/*
 * Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
 */

namespace _09_PrintSequence
{
    using System;
    using System.Text;

    class PrintSequence
    {
        static void Main()
        {
            int firstMember = 2;
            int tottalCount = 10;
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