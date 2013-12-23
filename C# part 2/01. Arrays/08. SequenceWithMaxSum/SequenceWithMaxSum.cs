/*
 * Write a program that finds the sequence of maximal sum in given array. Example:
 * {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
 * Can you do it with only one loop (with single scan through the elements of the array)?
 */

using System;

class SequenceWithMaxSum
{
    static void Main()
    {
        Console.Write("How many numbers do you want to input? ");
        int count = int.Parse(Console.ReadLine());
        int[] numbers = new int[count];//{ 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxSum = 0; //variable to store the maximal found sum
        int currentSum = 0; // variable to store the sum of the current sequence
        int firstMember = 0; //variable to store the index of the first member of the sequence for the output
        int lastMember = 0; //variable to store the index of the last member of the sequence for the output

        //We check all possible sequences from the given array
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            currentSum += numbers[i];
            for (int j = i + 1; j < numbers.Length; j++)
            {
                currentSum += numbers[j];

                //if we find sum greater than the previous we set new values of the three variables
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    firstMember = i;
                    lastMember = j;
                }
            }
            //When we check all the possible sequences with first member "i" we unset the value of the current sum variable
            currentSum = 0;
        }

        //output
        Console.WriteLine("The maximal sum is {0}", maxSum);
        Console.WriteLine("The sequence is:");

        for (int i = firstMember; i <= lastMember; i++)
        {
            Console.WriteLine("index[{0}] -> {1}", i, numbers[i]);
        }
    }
}