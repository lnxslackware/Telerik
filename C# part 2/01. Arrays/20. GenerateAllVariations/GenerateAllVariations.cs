/*
 * Write a program that reads two numbers N and K and generates all the variations
 * of K elements from the set [1..N].
 * Example: N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
 */

using System;

class GenerateAllVariations
{
    static void PrintVariations(int[] arr, int currentPosition, int maxNumber)
    {
        if (currentPosition >= arr.Length)
        {
            //Output
            Console.Write("{{{0}}} ", string.Join(", ", arr));
        }
        else
        {
            for (int i = 1; i <= maxNumber; i++)
            {
                arr[currentPosition] = i;
                PrintVariations(arr, currentPosition + 1, maxNumber);
            }
        }
    }
    static void Main()
    {
        //Input
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        int[] numbers = new int[k];

        PrintVariations(numbers, 0, n);
        Console.WriteLine();
    }
}