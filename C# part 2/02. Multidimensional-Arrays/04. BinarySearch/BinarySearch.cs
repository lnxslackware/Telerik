﻿/*
 * Write a program, that reads from the console an array of N integers and an integer K, 
 * sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
 */

using System;
class BinarySearch
{
    static void Main()
    {
        //Read the user input from the console and initialize the array
        Console.WriteLine("Enter N(count of elements in the array): ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Console.WriteLine("Enter array elements separated with a single space:");
        string userInput = Console.ReadLine();
        string[] userInputAsArray = userInput.Split(' ');
        int resultIndex = -1;

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(userInputAsArray[i]);
        }
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        //Sorting the array
        Array.Sort(numbers);

        //Finding element equal or nearest not grater than K

        for (int i = k; i >= 0; i--)
        {
            resultIndex = Array.BinarySearch(numbers, i);
            if (resultIndex > -1)
            {
                break;
            }
            
        }

        Console.WriteLine("The largest number in the array which is less or equal to \"K\" is with index {0} and has value {1}", resultIndex, numbers[resultIndex]);
    }
}