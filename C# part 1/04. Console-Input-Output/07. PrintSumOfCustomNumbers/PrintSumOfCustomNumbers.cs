using System;

class PrintSumOfCustomNumbers
{
    static void Main()
    {
        Console.Write("How many numbers do you want to collect: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        Console.WriteLine();

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number {0}: ", i);
            int newNumber = int.Parse(Console.ReadLine());
            sum = sum + newNumber;
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}