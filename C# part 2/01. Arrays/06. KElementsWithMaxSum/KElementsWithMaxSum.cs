/*
 * Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.
 */

using System;

class KElementsWithMaxSum
{
    static void Main()
    {
        //Reading the user's input and declaring and initializing the array
        Console.Write("How many members do you want to have in the array? ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("How many elements do you want to test? ");
        int k = int.Parse(Console.ReadLine());
        int maxSum = 0;

        //The idea is to sort the elements of the array and then the last K elements will have the maximal sum
        Array.Sort(numbers);

        Console.Write("The elements that have the maximal sum are: ");
        for (int i = numbers.Length - 1; i >= numbers.Length - k; i--)
        {
            if (i == numbers.Length - k) //checks if the current element is the last we want to display
            {
                Console.Write("and ");
            }
            Console.Write("{0} ", numbers[i]);
            maxSum += numbers[i];
        }

        Console.WriteLine();
        Console.WriteLine("The maximal sum is: {0}", maxSum);
    }
}