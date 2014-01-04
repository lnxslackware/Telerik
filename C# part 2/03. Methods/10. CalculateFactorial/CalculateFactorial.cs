/*
 * Write a program to calculate n! for each n in the range [1..100]. 
 * Hint: Implement first a method that multiplies a number represented 
 * as array of digits by given integer number. 
 */

using System;
using System.Numerics;

class CalculateFactorial
{
    static int[] Factorial(int number)
    {
        int[] result = new int[] { 1 };

        for (int i = number; i > 1; i--)
        {
            result = MultiplyArrayWithInt(result, i);
        }

        return result;
    }

    static int[] MultiplyArrayWithInt(int[] arr, int multiplier)
    {
        int[] result = new int[arr.Length + multiplier.ToString().Length];
        int lengthDifference = Math.Abs(result.Length - arr.Length);

        for (int i = 0; i < arr.Length; i++)
        {
            result[i + lengthDifference] = arr[i] * multiplier;
        }

        for (int i = result.Length - 1; i > 0; i--)
        {
            result[i - 1] += result[i] / 10;
            result[i] = result[i] % 10;
        }

        return result;
    }

    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.Write("{0}! -> ", i);
            Console.WriteLine(string.Join("", Factorial(i)).TrimStart('0'));
        }
    }
}