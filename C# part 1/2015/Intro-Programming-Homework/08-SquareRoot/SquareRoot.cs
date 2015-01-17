/*
 * Create a console application that calculates and prints the square root of the number 12345.
 * Find in Internet “how to calculate square root in C#”.
 */

namespace _08_SquareRoot
{
    using System;

    class SquareRoot
    {
        static void Main()
        {
            int number = 12345;
            double squareNumber = Math.Sqrt(number);
            Console.WriteLine("The square number of 12345 is {0}", squareNumber);
        }
    }
}