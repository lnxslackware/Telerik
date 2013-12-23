/*
 * Write a program that finds the maximal sequence of equal elements in an array.
 * Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.
 */

using System;

class MaximalSequenceOfEqualElements
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxEqualNumbers = 0;
        int counter = 1;
        int previousElement = 0;
        int lastEqualElement = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[previousElement])
            {
                counter++;
                if (counter > maxEqualNumbers)
                {
                    maxEqualNumbers = counter;
                    lastEqualElement = i;
                }
            }
            else
            {
                counter = 1;
                previousElement = i;
            }
        }

        Console.WriteLine(new string('-', 20));
        Console.WriteLine("The inputed array is:");
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine("The maximal sequence of equal elements has {0} elements", maxEqualNumbers);
        Console.WriteLine("Those elements are: ");

        for (int i = lastEqualElement - maxEqualNumbers + 1; i <= lastEqualElement; i++)
        {
            Console.WriteLine("[{0}] -> {1}", i, numbers[i]);
        }
    }
}