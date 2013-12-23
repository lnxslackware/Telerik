/*
 * Write a program that finds in given array of integers a sequence of given sum S (if present).
 * Example:	{4, 3, 1, 4, 2, 5, 8}, S=11 -> {4, 2, 5}
 */

using System;

class FindSequenceWithGivenSum
{
    static void Main()
    {
        Console.Write("How many numbers do you want to input? ");
        int count = int.Parse(Console.ReadLine());
        int[] numbers = new int[count];//{ 4, 3, 1, 4, 2, 5, 8 };

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the selected sum you want to search for: ");
        int sum = int.Parse(Console.ReadLine());
        int currentSum = 0;
        int firstMember = 0;
        int lastMember = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            currentSum += numbers[i];

            for (int j = i + 1; j < numbers.Length; j++)
            {
                currentSum += numbers[j];
                if (currentSum == sum)
                {
                    firstMember = i;
                    lastMember = j;
                }
            }

            currentSum = 0;
        }

        Console.Write("{");
        for (int i = firstMember; i <= lastMember; i++)
        {
            Console.Write("{0}", numbers[i]);
            if (i < lastMember)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("}} = {0}", sum);
    }
}