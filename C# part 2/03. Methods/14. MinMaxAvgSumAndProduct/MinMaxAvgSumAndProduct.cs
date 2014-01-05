/*
 * Write methods to calculate minimum, maximum, average, sum and product of 
 * given set of integer numbers. Use variable number of arguments.
 */

using System;
using System.Numerics;

class MinMaxAvgSumAndProduct
{
    static void GetMin(params int[] arr)
    {
        int min = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        Console.WriteLine(min);
    }

    static void GetMax(params int[] arr)
    {
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        Console.WriteLine(max);
    }

    static void CalculateAvarage(params int[] arr)
    {
        BigInteger sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        decimal avarage = (decimal)sum / arr.Length;

        Console.WriteLine(avarage);
    }

    static void CalculateSum(params int[] arr)
    {
        BigInteger sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        Console.WriteLine(sum);
    }

    static void CalculateProduct(params int[] arr)
    {
        BigInteger product = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }

        Console.WriteLine(product);
    }

    static int[] ReadSequenceOfNumbers()
    {
        string input = Console.ReadLine();
        string[] inputedNumbersAsArray = input.Split(' ');
        int[] numbers = new int[inputedNumbersAsArray.Length];

        for (int i = 0; i < inputedNumbersAsArray.Length; i++)
        {
            numbers[i] = int.Parse(inputedNumbersAsArray[i]);
        }

        return numbers;
    }

    static void Main()
    {
        Console.WriteLine("Enter the numbers you want separated by a single space.");
        Console.Write("Numbers: ");
        int[] numbers = ReadSequenceOfNumbers();

        Console.Write("The minimal number in the sequence is: ");
        GetMin(numbers);
        Console.Write("The maximal number in the sequence is: ");
        GetMax(numbers);
        Console.Write("The avarage of the given sequence is: ");
        CalculateAvarage(numbers);
        Console.Write("The sum of the sequence is: ");
        CalculateSum(numbers);
        Console.Write("The product of the sequence is: ");
        CalculateProduct(numbers);
    }
}