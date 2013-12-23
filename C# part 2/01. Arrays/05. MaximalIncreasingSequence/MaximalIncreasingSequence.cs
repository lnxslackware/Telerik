/*
 * Write a program that finds the maximal increasing sequence in an array.
 * Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.
 */

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        //user selected count of the array
        Console.Write("How many members do you want in the array? ");
        int numberOfMembers = int.Parse(Console.ReadLine());

        //creating the array
        int[] numbers = new int[numberOfMembers];

        //initializing the values of the array
        Console.WriteLine("Enter the values:");

        for (int i = 0; i < numberOfMembers; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        //declaring variables needed for the check and for the output
        int maxCount = 0;
        int previousMember = 0;
        int lastSequenceMember = 0;
        int currenSequenceCount = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[previousMember] + 1)
            {
                currenSequenceCount++;
                if (currenSequenceCount > maxCount)
                {
                    maxCount = currenSequenceCount;
                    lastSequenceMember = i;
                }
            }
            else
            {
                currenSequenceCount = 1;
            }
            previousMember = i;
        }

        //Output
        //check if there is an increasing sequence in the array
        if (maxCount > 1)
        {
            Console.WriteLine("The maximal increasing sequence in the array is:");

            for (int i = lastSequenceMember - maxCount + 1; i <= lastSequenceMember; i++)
            {
                Console.WriteLine("index: {0} -> value: {1}", i, numbers[i]);
            }
        }
        else
        {
            Console.WriteLine("There is no increasing sequence in the array!");
        }
    }
}