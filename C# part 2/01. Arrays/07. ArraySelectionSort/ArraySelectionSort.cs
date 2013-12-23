/*
 * Sorting an array means to arrange its elements in increasing order.
 * Write a program to sort an array. Use the "selection sort" algorithm:
 * Find the smallest element, move it at the first position, find the smallest from the rest,
 * move it at the second position, etc.
 */

using System;

class ArraySelectionSort
{
    static void Main()
    {
        //reading the array from the console
        Console.Write("How many numbers do you want to enter? ");
        int numbersCount = int.Parse(Console.ReadLine());
        int[] numbers = new int[numbersCount];

        Console.WriteLine("Enter the numbers:");
        for (int i = 0; i < numbersCount; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    numbers[i] += numbers[j];
                    numbers[j] = numbers[i] - numbers[j];
                    numbers[i] -= numbers[j];
                }
            }
        }

        Console.WriteLine("The sorted array is now:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("index[{0}] -> {1}", i, numbers[i]);
        }
    }
}