/*
 * Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).
 */

using System;

class FindIndexWithBinarySearch
{
    static void Main()
    {
        Console.Write("How many numbers do you want to input? ");
        int count = int.Parse(Console.ReadLine());
        int[] numbers = new int[count];//{ 6, 3, 1, 5, 4, 3, 7, 8, 5 };

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("What is the element you want to search for? ");
        int testedElement = int.Parse(Console.ReadLine());

        Array.Sort(numbers);
        int middle = numbers.Length / 2;
        int searchedIndex = -1;
        int indexesLeft = numbers.Length / 2;

        while (indexesLeft > 1)
        {
            if (testedElement == numbers[middle])
            {
                searchedIndex = middle;
                break;
            }
            else if (testedElement > numbers[middle])
            {
                middle = (numbers.Length + middle) / 2;
                indexesLeft /= 2;
            }
            else
            {
                middle = (numbers.Length - middle) / 2;
                indexesLeft /= 2;
            }
        }

        if (searchedIndex != -1)
        {
            Console.WriteLine("The index of {0} is {1}", testedElement, middle);
        }
        else
        {
            Console.WriteLine("There is no such number in the array!");
        }
    }
}