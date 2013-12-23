/*
 * Write a program that reads two numbers N and K and generates all the combinations of
 * K distinct elements from the set [1..N].
 * Example: N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
 */

using System;
class GenerateAllCombinations
{
    static void GenerateCombinations(int[] numbersArray, int index, int minNumber, int maxNumber)
    {
        if (index >= numbersArray.Length)
        {
            //Output
            Console.Write("{{{0}}} ", string.Join(", ", numbersArray));
        }
        else
        {
            for (int i = minNumber; i <= maxNumber; i++)
            {
                numbersArray[index] = i;
                GenerateCombinations(numbersArray, index + 1, i + 1, maxNumber);
            }
        }
    }
    static void Main()
    {
        //User input
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        int[] numbers = new int[k];

        GenerateCombinations(numbers, 0, 1, n);
        Console.WriteLine();
    }
}