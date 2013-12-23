using System;
using System.Numerics;

class FibonacciSequence
{
    static void Main()
    {
        Console.Write("How many members of the Fibonacci sequence do you want to display? ");
        int count = int.Parse(Console.ReadLine());
        decimal firstFibonacciMember = 0M;
        decimal secondFibonacciMember = 1M;
        decimal sum;

        Console.WriteLine("{0}", firstFibonacciMember);
        Console.WriteLine("{0}", secondFibonacciMember);

        for (int i = 1; i < count - 1; i++)
        {
            sum = firstFibonacciMember + secondFibonacciMember;
            Console.WriteLine("{0}", sum);
            firstFibonacciMember = secondFibonacciMember;
            secondFibonacciMember = sum;
        }
    }
}