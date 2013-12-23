using System;

class SumOfFibonaciMembers
{
    static void Main()
    {
        int count;

        do
        {
            Console.Write("How many members of the Fibonacci sequence do you want to calculate? ");
        }
        while (!int.TryParse(Console.ReadLine(), out count));

        decimal firstFibonacciMember = 0M;
        decimal secondFibonacciMember = 1M;
        decimal lastFibonacciMember;
        decimal sum = 1;

        for (int i = 1; i < count - 1; i++)
        {
            lastFibonacciMember = firstFibonacciMember + secondFibonacciMember;
            firstFibonacciMember = secondFibonacciMember;
            secondFibonacciMember = lastFibonacciMember;
            sum += lastFibonacciMember;
        }
        Console.WriteLine("The sum of the first {0} members of the sequence of Fibonacci is {1}", count, sum);
    }
}