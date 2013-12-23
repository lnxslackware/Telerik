/*
 * Write a program that finds the most frequent number in an array.
 * Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)
 */

using System;

class FindMoreFrequentNumber
{
    static void Main()
    {
        Console.Write("How many numbers do you want to input? ");
        int count = int.Parse(Console.ReadLine());
        int[] numbers = new int[count];//{ 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int mostFrequentNumber = 0; //Variable to store the most frequent number at the moment
        int currentCount = 1; //To count the current found matches
        int maxCount = 0; //To store the maximal found count of same numbers

        for (int i = 0; i < numbers.Length; i++)
        {

            for (int j = 0; j < numbers.Length; j++)
            {
                if ((numbers[i] == numbers[j]) && (i != j)) //Checks if the number is equal to the tested one and we are not checking the number with the same index
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        mostFrequentNumber = numbers[i];
                    }
                }
            }
            currentCount = 1; //We reset the variable at the end of every check
        }

        Console.WriteLine("The most frequent number in the array is {0} ({1} times)", mostFrequentNumber, maxCount);
    }
}