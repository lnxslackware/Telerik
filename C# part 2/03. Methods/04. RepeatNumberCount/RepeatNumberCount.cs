/*
 * Write a method that counts how many times given number appears in given array. 
 * Write a test program to check if the method is working correctly.
 */

using System;

public class RepeatNumberCount
{
    public static int GetRepsCountInArray(int[] arr, int number)
    {
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == number)
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        //Reading user's data
        Console.Write("How many numbers are in the array? ");
        int arrayLength = int.Parse(Console.ReadLine());

        int[] numbers = new int[arrayLength];

        Console.WriteLine("Input the values of the array(separated by spaces):");
        string userInput = Console.ReadLine();
        string[] userInputAsArray = userInput.Split(' ');

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(userInputAsArray[i]);
        }

        Console.Write("Input the number you want to count: ");
        int searchedNumber = int.Parse(Console.ReadLine());

        int count = GetRepsCountInArray(numbers, searchedNumber);

        Console.WriteLine(count);
    }
}